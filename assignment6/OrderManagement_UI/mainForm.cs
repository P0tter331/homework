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
            // ����ÿ����������һ����Ϊ "OrderDetails" �����ԣ�������������ϸ�б�
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
            decimal? minTotalAmount = null;
            if (!string.IsNullOrWhiteSpace(minTotalAmountTextBox.Text))
            {
                minTotalAmount = decimal.Parse(minTotalAmountTextBox.Text);  // �����û�����������Ч������
            }

            var results = orderService.QueryOrders(
                orderIdTextBox.Text,
                customerNameTextBox.Text,
                productNameTextBox.Text,
                minTotalAmount
            );

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
    }
}
