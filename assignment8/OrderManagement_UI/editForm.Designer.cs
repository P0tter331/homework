namespace OrderManagement_UI
{
    partial class editForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            comboBoxCustomer = new ComboBox();
            textBoxOrderId = new TextBox();
            dataGridViewItems = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            ColQuantity = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 483);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancel);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(comboBoxCustomer);
            splitContainer1.Panel1.Controls.Add(textBoxOrderId);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewItems);
            splitContainer1.Size = new Size(823, 483);
            splitContainer1.SplitterDistance = 390;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(233, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 60);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(27, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 57);
            btnSave.TabIndex = 4;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(109, 27);
            label2.TabIndex = 3;
            label2.Text = "选择客户";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 2;
            label1.Text = "输入订单ID";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(123, 93);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(198, 28);
            comboBoxCustomer.TabIndex = 1;
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOrderId.Location = new Point(123, 29);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.Size = new Size(198, 27);
            textBoxOrderId.TabIndex = 0;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { ColName, ColQuantity });
            dataGridViewItems.Dock = DockStyle.Fill;
            dataGridViewItems.Location = new Point(0, 0);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(429, 483);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.CellContentClick += dataGridViewItems_CellContentClick;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.HeaderText = "Product.Name";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            // 
            // ColQuantity
            // 
            ColQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColQuantity.HeaderText = "Quantity";
            ColQuantity.MinimumWidth = 6;
            ColQuantity.Name = "ColQuantity";
            // 
            // editForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 483);
            Controls.Add(panel1);
            Name = "editForm";
            Text = "editForm";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private TextBox textBoxOrderId;
        private ComboBox comboBoxCustomer;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewItems;
        private Button btnCancel;
        private Button btnSave;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColQuantity;
    }
}