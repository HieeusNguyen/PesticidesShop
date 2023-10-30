namespace QuanLyCuaHangThuocSau
{
    partial class CashForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCash = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Increase = new DataGridViewImageColumn();
            Decrease = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            btnCash = new Guna.UI2.WinForms.Guna2Button();
            lblTotalPrice = new Label();
            lblTransno = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCash).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCash
            // 
            dgvCash.AllowUserToAddRows = false;
            dgvCash.BackgroundColor = SystemColors.ControlLight;
            dgvCash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle1.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCash.ColumnHeadersHeight = 33;
            dgvCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column9, Column3, Column6, Column7, Column8, Column4, Column5, Increase, Decrease, Delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCash.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCash.Dock = DockStyle.Fill;
            dgvCash.EnableHeadersVisualStyles = false;
            dgvCash.Location = new Point(0, 67);
            dgvCash.Name = "dgvCash";
            dgvCash.RowHeadersVisible = false;
            dgvCash.RowHeadersWidth = 51;
            dgvCash.RowTemplate.Height = 29;
            dgvCash.Size = new Size(1000, 233);
            dgvCash.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 68;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "CashID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 95;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Pcode";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 84;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Họ Tên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "Số lượng";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 109;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle3;
            Column7.HeaderText = "Giá";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 64;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle4;
            Column8.HeaderText = "Tổng ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 81;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Tên Thành Viên";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 162;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Cashier";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 96;
            // 
            // Increase
            // 
            Increase.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Increase.HeaderText = "";
            Increase.Image = (Image)resources.GetObject("Increase.Image");
            Increase.MinimumWidth = 6;
            Increase.Name = "Increase";
            Increase.Width = 6;
            // 
            // Decrease
            // 
            Decrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Decrease.HeaderText = "";
            Decrease.Image = (Image)resources.GetObject("Decrease.Image");
            Decrease.MinimumWidth = 6;
            Decrease.Name = "Decrease";
            Decrease.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCash);
            panel2.Controls.Add(lblTotalPrice);
            panel2.Controls.Add(lblTransno);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 57);
            panel2.TabIndex = 4;
            // 
            // btnCash
            // 
            btnCash.AutoRoundedCorners = true;
            btnCash.BorderRadius = 23;
            btnCash.CustomizableEdges = customizableEdges1;
            btnCash.DisabledState.BorderColor = Color.DarkGray;
            btnCash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCash.FillColor = Color.FromArgb(3, 172, 220);
            btnCash.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.ForeColor = Color.White;
            btnCash.Location = new Point(833, 5);
            btnCash.Name = "btnCash";
            btnCash.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCash.Size = new Size(158, 49);
            btnCash.TabIndex = 10;
            btnCash.Text = "Cash";
            btnCash.Click += btnCash_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Location = new Point(664, 18);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(127, 25);
            lblTotalPrice.TabIndex = 9;
            lblTotalPrice.Text = "0.00";
            lblTotalPrice.TextAlign = ContentAlignment.TopCenter;
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // lblTransno
            // 
            lblTransno.Location = new Point(359, 18);
            lblTransno.Name = "lblTransno";
            lblTransno.Size = new Size(127, 25);
            lblTransno.TabIndex = 7;
            lblTransno.Text = "000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 172, 220);
            label3.Location = new Point(547, 18);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 6;
            label3.Text = "Total Price $:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 172, 220);
            label2.Location = new Point(217, 18);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 5;
            label2.Text = "Transaction no: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 22);
            label1.TabIndex = 4;
            label1.Text = "Product";
            // 
            // btnAdd
            // 
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverState.BorderColor = Color.Transparent;
            btnAdd.HoverState.FillColor = Color.Transparent;
            btnAdd.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(0, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(49, 43);
            btnAdd.TabIndex = 3;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderRadius = 18;
            txtSearch.CustomizableEdges = customizableEdges5;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(1494, 6);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Tìm kiếm";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearch.Size = new Size(291, 47);
            txtSearch.TabIndex = 2;
            txtSearch.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 10);
            panel1.TabIndex = 3;
            // 
            // CashForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 300);
            Controls.Add(dgvCash);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashForm";
            Text = "Cash";
            ((System.ComponentModel.ISupportInitialize)dgvCash).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCash;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private Label lblTotalPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Increase;
        private DataGridViewImageColumn Decrease;
        private DataGridViewImageColumn Delete;
        public Label lblTransno;
    }
}