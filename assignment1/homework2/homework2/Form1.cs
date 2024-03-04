using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox.Items.Add("+");
            comboBox.Items.Add("-");
            comboBox.Items.Add("*");
            comboBox.Items.Add("/");
            comboBox.SelectedIndex = 0; // 设置默认选定项为第一项（"+"）
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;

            //判断输入的数字a、b是否有效
            bool isa = double.TryParse(textBox1.Text, out a);
            bool isb = double.TryParse(textBox2.Text, out b);

            if (!isa || !isb) { label1.Text = "Please enter a valid number!!"; return; }

            switch (comboBox.SelectedItem.ToString())
            {
                case "+":
                    c = a + b;
                    label1.Text = $"{c}";
                    break;
                case "-":
                    c = a - b;
                    label1.Text = $"{c}";
                    break;
                case "*":
                    c = a * b;
                    label1.Text = $"{c}";
                    break;
                case "/":
                    if (b != 0)
                    {
                        c = a / b;
                        label1.Text = $"{c}";
                        break;
                    }
                    else
                    {
                        label1.Text = $"The divisor cannot be 0.";
                    }
                    return;

                default:
                    label1.Text = $"The operator you entered is incorrect.";
                    return;
            }
        }
    }
}
