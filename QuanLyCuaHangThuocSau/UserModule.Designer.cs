namespace QuanLyCuaHangThuocSau
{
    partial class UserModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPass = new TextBox();
            label7 = new Label();
            lbluid = new Label();
            cbRole = new ComboBox();
            dtDob = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 10);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 1;
            label1.Text = "Đăng Ký Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên :";
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(528, 29);
            txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 129);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(528, 29);
            txtAddress.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 132);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 4;
            label3.Text = "Địa chỉ :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(182, 178);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(528, 29);
            txtPhone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 181);
            label4.Name = "label4";
            label4.Size = new Size(123, 22);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 232);
            label5.Name = "label5";
            label5.Size = new Size(85, 22);
            label5.TabIndex = 8;
            label5.Text = "Chức vụ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 286);
            label6.Name = "label6";
            label6.Size = new Size(97, 22);
            label6.TabIndex = 10;
            label6.Text = "Ngày sinh :";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(182, 335);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(528, 29);
            txtPass.TabIndex = 5;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 338);
            label7.Name = "label7";
            label7.Size = new Size(97, 22);
            label7.TabIndex = 12;
            label7.Text = "Mật Khẩu :";
            label7.Click += label7_Click;
            // 
            // lbluid
            // 
            lbluid.AutoSize = true;
            lbluid.Location = new Point(32, 393);
            lbluid.Name = "lbluid";
            lbluid.Size = new Size(35, 22);
            lbluid.TabIndex = 14;
            lbluid.Text = "uid";
            lbluid.Visible = false;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Quản Lý", "Thu Ngân", "Nhân Viên" });
            cbRole.Location = new Point(182, 229);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(528, 30);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // dtDob
            // 
            dtDob.Location = new Point(182, 281);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(528, 29);
            dtDob.TabIndex = 4;
            dtDob.Value = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoEllipsis = true;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(182, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnUpdate.Location = new Point(384, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 52);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoEllipsis = true;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(580, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 52);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Xóa";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // guna2Button7
            // 
            guna2Button7.CustomizableEdges = customizableEdges3;
            guna2Button7.DisabledState.BorderColor = Color.DarkGray;
            guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button7.FillColor = Color.Transparent;
            guna2Button7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button7.ForeColor = Color.White;
            guna2Button7.HoverState.BorderColor = Color.Transparent;
            guna2Button7.HoverState.FillColor = Color.Transparent;
            guna2Button7.HoverState.Image = (Image)resources.GetObject("resource.Image");
            guna2Button7.Image = (Image)resources.GetObject("guna2Button7.Image");
            guna2Button7.Location = new Point(750, 11);
            guna2Button7.Name = "guna2Button7";
            guna2Button7.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button7.Size = new Size(49, 43);
            guna2Button7.TabIndex = 9;
            guna2Button7.Click += guna2Button7_Click;
            // 
            // UserModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button7);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtDob);
            Controls.Add(cbRole);
            Controls.Add(lbluid);
            Controls.Add(txtPass);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        public TextBox txtPass;
        public TextBox txtPhone;
        public TextBox txtAddress;
        public TextBox txtName;
        public Button btnSave;
        public DateTimePicker dtDob;
        public ComboBox cbRole;
        public Label lbluid;
        public Button btnUpdate;
    }
}