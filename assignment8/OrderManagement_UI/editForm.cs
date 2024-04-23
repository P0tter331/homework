using OrderManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement_UI
{
    public partial class editForm : Form
    {
        private Order currentOrder;
        private BindingList<OrderDetails> orderDetailsBindingList;
        public editForm(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            orderDetailsBindingList = new BindingList<OrderDetails>(currentOrder.OrderDetails);

            dataGridViewItems.DataSource = orderDetailsBindingList;

            // 设置ComboBox和TextBox的值等
            comboBoxCustomer.SelectedValue = currentOrder.Customer.CustomerId;
            textBoxOrderId.Text = currentOrder.OrderId;

            // 绑定事件
            orderDetailsBindingList.ListChanged += OrderDetailsBindingList_ListChanged;
        }


        private void OrderDetailsBindingList_ListChanged(object sender, ListChangedEventArgs e)
        {
            // 处理订单明细变更逻辑
            if (e.ListChangedType == ListChangedType.ItemAdded ||
                e.ListChangedType == ListChangedType.ItemDeleted ||
                e.ListChangedType == ListChangedType.ItemChanged)
            {
                // 实施必要的数据更新
                // 可能的操作: 验证数据, 日志记录, 等等
            }
        }


        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 保存逻辑
            // 可能需要将更改写回数据库或主存储
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
