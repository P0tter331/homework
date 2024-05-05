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

            // ������ BindingSource ������ԴΪ�����б�
            ordersBindingSource.DataSource = orderService.GetOrders();

            // �������ݰ󶨵� DataGridView
            ordersDataGridView.DataSource = ordersBindingSource;

            // ���ô� BindingSource ������ԴΪ�� BindingSource
            // ÿ����������һ����Ϊ "OrderDetails" �����ԣ�������������ϸ�б�
            orderDetailsBindingSource.DataSource = ordersBindingSource;
            orderDetailsBindingSource.DataMember = "OrderDetails";

            // ����еڶ��� DataGridView ������ʾ������ϸ������������
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
                    MessageBox.Show("��������Ч�Ľ��");
                    return;
                }
            }

            var results = orderService.QueryOrders(orderId, customerName, productName, minTotalAmount);

            // ���¶��� DataGridView ������Դ
            ordersBindingSource.DataSource = results;
            ordersDataGridView.DataSource = ordersBindingSource;

            // ������еĶ�����ϸ��ʾ
            orderDetailsBindingSource.DataSource = null;
        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null)
            {
                // ��ȡ��ǰѡ�еĶ���
                Order selectedOrder = ordersDataGridView.CurrentRow.DataBoundItem as Order;

                if (selectedOrder != null)
                {
                    // ��ʾѡ�ж�������ϸ
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
            var orders = orderService.GetOrders(); // ��ȡ���µĶ����б�
            bindingSource1.DataSource = orders;    // ���°�Դ
            ordersDataGridView.DataSource = bindingSource1; // ���°� DataGridView
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            editForm orderForm = new editForm(newOrder);
            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                // �����OrderForm�е���˱��棬���Ҳ����ɹ���������¶������б�
                // ���磬��ӵ�OrderService�еĶ����б�
                orderService.AddOrder(newOrder);
                // ������Ҫ�����������ϵĶ�����ʾ�б�
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
                    // ������Ҫˢ����ʾ�Ķ����б�
                    RefreshOrdersDisplay();
                }
            }
            else
            {
                MessageBox.Show("��ѡ��һ���������б༭��");
            }
        }
    }
}
