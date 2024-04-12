using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace UI_OrderManagement
{
    public partial class Form1 : Form
    {
        private OrderService orderService;
        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            resultBox.Clear();  // 清除之前的查询结果

            if (radio1.Checked)
            {
                // 解析作为订单编号
                if (int.TryParse(queryBox.Text, out int orderId))
                {
                    var orders = orderService.QueryOrders(orderId.ToString());
                    if (orders.Any())
                    {
                        foreach (var order in orders)
                        {
                            resultBox.AppendText(order.ToString() + Environment.NewLine);
                        }
                    }
                    else
                    {
                        resultBox.Text = "未找到指定的订单编号。";
                    }
                }
                else
                {
                    resultBox.Text = "请输入有效的订单编号！";
                }
            }
            else if (radio2.Checked)
            {
                // 解析作为客户名称
                string customerName = queryBox.Text;
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    var orders = orderService.QueryOrders(customerName);
                    if (orders.Any())
                    {
                        foreach (var order in orders)
                        {
                            resultBox.AppendText(order.ToString() + Environment.NewLine);
                        }
                    }
                    else
                    {
                        resultBox.Text = "未找到指定的客户名称。";
                    }
                }
                else
                {
                    resultBox.Text = "请输入客户名称！";
                }
            }
            else
            {
                resultBox.Text = "请选择一种查询方式。";
            }
        }
    }
}
