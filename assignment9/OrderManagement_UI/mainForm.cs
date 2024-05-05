using OrderManagement;
using System.Windows.Forms;

namespace OrderManagement_UI
{
    public partial class mainForm : Form
    {
        private OrderService orderService;
        private BindingSource ordersBindingSource = new BindingSource();
        private BindingSource orderDetailsBindingSource = new BindingSource();
        public mainForm()
        {
            InitializeComponent();

            orderService = new OrderService();

            // 设置主 BindingSource 的数据源为订单列表
            ordersBindingSource.DataSource = orderService.GetOrders();

            // 将主数据绑定到 DataGridView
            ordersDataGridView.DataSource = ordersBindingSource;

            // 设置从 BindingSource 的数据源为主 BindingSource
            // 每个订单中有一个名为 "OrderDetails" 的属性，它包含订单明细列表
            orderDetailsBindingSource.DataSource = ordersBindingSource;
            orderDetailsBindingSource.DataMember = "OrderDetails";

            // 如果有第二个 DataGridView 用于显示订单明细，可以这样绑定
            orderDetailsDataGridView.DataSource = orderDetailsBindingSource;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            string orderId = orderIdTextBox.Text;
            string customerName = customerNameTextBox.Text;
            string productName = productNameTextBox.Text;
            decimal? minTotalAmount = null;

            if (!string.IsNullOrWhiteSpace(minTotalAmountTextBox.Text))
            {
                if (decimal.TryParse(minTotalAmountTextBox.Text, out decimal result))
                {
                    minTotalAmount = result;
                }
                else
                {
                    MessageBox.Show("请输入有效的金额");
                    return;
                }
            }

            var results = orderService.QueryOrders(orderId, customerName, productName, minTotalAmount);

            // 更新订单 DataGridView 的数据源
            ordersBindingSource.DataSource = results;
            ordersDataGridView.DataSource = ordersBindingSource;

            // 清除既有的订单明细显示
            orderDetailsBindingSource.DataSource = null;
        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null)
            {
                // 获取当前选中的订单
                Order selectedOrder = ordersDataGridView.CurrentRow.DataBoundItem as Order;

                if (selectedOrder != null)
                {
                    // 显示选中订单的明细
                    orderDetailsBindingSource.DataSource = selectedOrder.OrderDetails;
                    orderDetailsDataGridView.DataSource = orderDetailsBindingSource;
                }
            }
        }

        private Order GetSelectedOrder()
        {
            if (ordersDataGridView.CurrentRow != null)
            {
               
                return ordersDataGridView.CurrentRow.DataBoundItem as Order;
            }
            return null;
        }

        private void RefreshOrdersDisplay()
        {
            var orders = orderService.GetOrders(); // 获取最新的订单列表
            bindingSource1.DataSource = orders;    // 更新绑定源
            ordersDataGridView.DataSource = bindingSource1; // 重新绑定 DataGridView
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            editForm orderForm = new editForm(newOrder);
            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                // 如果在OrderForm中点击了保存，并且操作成功，则添加新订单到列表
                // 例如，添加到OrderService中的订单列表
                orderService.AddOrder(newOrder);
                // 可能需要更新主窗体上的订单显示列表
                RefreshOrdersDisplay();

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Order selectedOrder = GetSelectedOrder();
            if (selectedOrder != null)
            {
                editForm editForm = new editForm(selectedOrder);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 可能需要刷新显示的订单列表
                    RefreshOrdersDisplay();
                }
            }
            else
            {
                MessageBox.Show("请选择一个订单进行编辑。");
            }
        }
    }
}
