namespace QuanLyCuaHangThuocSau
{
    partial class CustomerModule
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblCid = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtPhone = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.HoverState.BorderColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Transparent;
            btnClose.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(750, 20);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(49, 43);
            btnClose.TabIndex = 30;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoEllipsis = true;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(580, 251);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 52);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Xóa";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.AutoEllipsis = true;
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(384, 251);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 52);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoEllipsis = true;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(182, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 52);
            btnSave.TabIndex = 25;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCid
            // 
            lblCid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCid.AutoSize = true;
            lblCid.Location = new Point(32, 266);
            lblCid.Name = "lblCid";
            lblCid.Size = new Size(35, 22);
            lblCid.TabIndex = 33;
            lblCid.Text = "uid";
            lblCid.Visible = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(528, 29);
            txtAddress.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 23;
            label3.Text = "Địa chỉ :";
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(528, 29);
            txtName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 20;
            label2.Text = "Tên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 18;
            label1.Text = "Thành Viên";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(182, 187);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(528, 29);
            txtPhone.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 190);
            label4.Name = "label4";
            label4.Size = new Size(123, 22);
            label4.TabIndex = 26;
            label4.Text = "Số điện thoại :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 10);
            panel1.TabIndex = 15;
            // 
            // CustomerModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 311);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblCid);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(panel1);
            Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerModule";
            Load += CustomerModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public Label lblCid;
        public TextBox txtAddress;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public TextBox txtPhone;
        private Label label4;
        private Panel panel1;
    }
}