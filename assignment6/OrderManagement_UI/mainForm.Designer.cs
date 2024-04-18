namespace OrderManagement_UI
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            create_btn = new Button();
            remove_btn = new Button();
            edit_btn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            query_btn = new Button();
            label1 = new Label();
            orderIdTextBox = new TextBox();
            label2 = new Label();
            customerNameTextBox = new TextBox();
            label3 = new Label();
            productNameTextBox = new TextBox();
            label4 = new Label();
            minTotalAmountTextBox = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ordersDataGridView = new DataGridView();
            orderDetailsDataGridView = new DataGridView();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 685);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel3);
            splitContainer1.Size = new Size(1243, 685);
            splitContainer1.SplitterDistance = 629;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(create_btn);
            flowLayoutPanel2.Controls.Add(remove_btn);
            flowLayoutPanel2.Controls.Add(edit_btn);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 629);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(629, 56);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // create_btn
            // 
            create_btn.Dock = DockStyle.Fill;
            create_btn.Location = new Point(3, 3);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(177, 41);
            create_btn.TabIndex = 0;
            create_btn.Text = "创建订单";
            create_btn.UseVisualStyleBackColor = true;
            // 
            // remove_btn
            // 
            remove_btn.Dock = DockStyle.Fill;
            remove_btn.Location = new Point(186, 3);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(171, 41);
            remove_btn.TabIndex = 1;
            remove_btn.Text = "删除订单";
            remove_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit_btn.Location = new Point(363, 3);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(213, 41);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "修改订单";
            edit_btn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(query_btn);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(orderIdTextBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(customerNameTextBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(productNameTextBox);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(minTotalAmountTextBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(629, 685);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // query_btn
            // 
            query_btn.Location = new Point(3, 3);
            query_btn.Name = "query_btn";
            query_btn.Size = new Size(177, 53);
            query_btn.TabIndex = 0;
            query_btn.Text = "查询订单";
            query_btn.UseVisualStyleBackColor = true;
            query_btn.Click += query_btn_Click;
            // 
            // label1
            // 
            label1.Location = new Point(3, 59);
            label1.Name = "label1";
            label1.Size = new Size(177, 55);
            label1.TabIndex = 2;
            label1.Text = "输入订单ID";
            // 
            // orderIdTextBox
            // 
            orderIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderIdTextBox.Location = new Point(3, 117);
            orderIdTextBox.Name = "orderIdTextBox";
            orderIdTextBox.Size = new Size(354, 27);
            orderIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(3, 147);
            label2.Name = "label2";
            label2.Size = new Size(177, 55);
            label2.TabIndex = 4;
            label2.Text = "输入客户名称";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customerNameTextBox.Location = new Point(3, 205);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(354, 27);
            customerNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(3, 235);
            label3.Name = "label3";
            label3.Size = new Size(177, 55);
            label3.TabIndex = 6;
            label3.Text = "输入商品名称";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            productNameTextBox.Location = new Point(3, 293);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(354, 27);
            productNameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(3, 323);
            label4.Name = "label4";
            label4.Size = new Size(177, 55);
            label4.TabIndex = 8;
            label4.Text = "输入最小金额";
            // 
            // minTotalAmountTextBox
            // 
            minTotalAmountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minTotalAmountTextBox.Location = new Point(3, 381);
            minTotalAmountTextBox.Name = "minTotalAmountTextBox";
            minTotalAmountTextBox.Size = new Size(354, 27);
            minTotalAmountTextBox.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(ordersDataGridView);
            flowLayoutPanel3.Controls.Add(orderDetailsDataGridView);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(610, 685);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(3, 3);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.Size = new Size(300, 682);
            ordersDataGridView.TabIndex = 0;
            // 
            // orderDetailsDataGridView
            // 
            orderDetailsDataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            orderDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsDataGridView.Location = new Point(309, 3);
            orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            orderDetailsDataGridView.RowHeadersWidth = 51;
            orderDetailsDataGridView.Size = new Size(310, 682);
            orderDetailsDataGridView.TabIndex = 1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 685);
            Controls.Add(panel1);
            Name = "mainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button create_btn;
        private Button remove_btn;
        private Button edit_btn;
        private BindingSource bindingSource1;
        private FlowLayoutPanel flowLayoutPanel3;
        private DataGridView ordersDataGridView;
        private DataGridView orderDetailsDataGridView;
        private BindingSource bindingSource2;
        private Button query_btn;
        private Label label1;
        private TextBox orderIdTextBox;
        private Label label2;
        private TextBox customerNameTextBox;
        private Label label3;
        private TextBox productNameTextBox;
        private Label label4;
        private TextBox minTotalAmountTextBox;
    }
}
