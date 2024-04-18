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
            // 假设每个订单中有一个名为 "OrderDetails" 的属性，它包含订单明细列表
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
            decimal? minTotalAmount = null;
            if (!string.IsNullOrWhiteSpace(minTotalAmountTextBox.Text))
            {
                minTotalAmount = decimal.Parse(minTotalAmountTextBox.Text);  // 假设用户总是输入有效的数字
            }

            var results = orderService.QueryOrders(
                orderIdTextBox.Text,
                customerNameTextBox.Text,
                productNameTextBox.Text,
                minTotalAmount
            );

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
    }
}
