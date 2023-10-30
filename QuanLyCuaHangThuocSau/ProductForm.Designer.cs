namespace QuanLyCuaHangThuocSau
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            txtSeacrh = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtSearchNone = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = SystemColors.ControlLight;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle1.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 33;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 67);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(1000, 233);
            dgvProduct.TabIndex = 5;
            dgvProduct.CellContentClick += dgvUser_CellContentClick;
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
            Column2.HeaderText = "Mã Sản Phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 145;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Tên Sản Phẩm";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Nhập";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 79;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Loại Sản Phẩm";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 154;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Số Lượng";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 114;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Giá";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 64;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
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
            panel2.Controls.Add(txtSeacrh);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtSearchNone);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 57);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // txtSeacrh
            // 
            txtSeacrh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSeacrh.BackColor = Color.Transparent;
            txtSeacrh.BorderRadius = 18;
            txtSeacrh.CustomizableEdges = customizableEdges1;
            txtSeacrh.DefaultText = "";
            txtSeacrh.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSeacrh.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSeacrh.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSeacrh.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSeacrh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeacrh.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeacrh.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSeacrh.IconLeft = (Image)resources.GetObject("txtSeacrh.IconLeft");
            txtSeacrh.Location = new Point(696, 4);
            txtSeacrh.Margin = new Padding(4, 3, 4, 3);
            txtSeacrh.Name = "txtSeacrh";
            txtSeacrh.PasswordChar = '\0';
            txtSeacrh.PlaceholderText = "Tìm kiếm";
            txtSeacrh.SelectedText = "";
            txtSeacrh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSeacrh.Size = new Size(291, 47);
            txtSeacrh.TabIndex = 6;
            txtSeacrh.TextChanged += txtSeacrh_TextChanged;
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
            // txtSearchNone
            // 
            txtSearchNone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchNone.BackColor = Color.Transparent;
            txtSearchNone.BorderRadius = 18;
            txtSearchNone.CustomizableEdges = customizableEdges5;
            txtSearchNone.DefaultText = "";
            txtSearchNone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchNone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchNone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchNone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchNone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchNone.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchNone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchNone.IconLeft = (Image)resources.GetObject("txtSearchNone.IconLeft");
            txtSearchNone.Location = new Point(1494, 6);
            txtSearchNone.Margin = new Padding(4, 3, 4, 3);
            txtSearchNone.Name = "txtSearchNone";
            txtSearchNone.PasswordChar = '\0';
            txtSearchNone.PlaceholderText = "Tìm kiếm";
            txtSearchNone.SelectedText = "";
            txtSearchNone.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearchNone.Size = new Size(291, 47);
            txtSearchNone.TabIndex = 2;
            txtSearchNone.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 10);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // ProductForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 300);
            Controls.Add(dgvProduct);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNone;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Guna.UI2.WinForms.Guna2TextBox txtSeacrh;
    }
}