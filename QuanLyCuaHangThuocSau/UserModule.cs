using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangThuocSau
{
    public partial class UserModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        string title = "Quản Lý Cửa Hàng Thuốc Bảo Vệ Thực Vật";

        UserForm userForm;
        bool check = false;
        public UserModule(UserForm user)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            userForm = user;
            cbRole.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc muốn đăng ký tài khoản này?", "Đăng Ký Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("INSERT INTO tbUser (name, address, phone, role, dob, password) VALUES(@name, @address, @phone, @role, @dob, @password)", cn);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@role", cbRole.Text);
                        cmd.Parameters.AddWithValue("@dob", dtDob.Value);
                        cmd.Parameters.AddWithValue("@password", txtPass.Text);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Đăng kí thành công", title);
                        Clear();
                        userForm.LoadUser();
                        this.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa bản ghi này không?", "Sửa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("UPDATE tbUser SET name=@name, address=@address, phone=@phone, role=@role, dob=@dob, password=@password WHERE id=@id", cn);
                        cmd.Parameters.AddWithValue("@id", lbluid.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@role", cbRole.Text);
                        cmd.Parameters.AddWithValue("@dob", dtDob.Value);
                        cmd.Parameters.AddWithValue("@password", txtPass.Text);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Sửa thành công", title);
                        Clear();
                        userForm.LoadUser();
                        this.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.Text == "Nhân Viên")
            {
                this.Height = 450 - 26;
                txtPass.Visible = false;
                label7.Visible = false;
            }
            else
            {
                this.Height = 450;
                txtPass.Visible = true;
                label7.Visible = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        #region Method

        public void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPass.Clear();
            cbRole.SelectedIndex = 0;
            dtDob.Value = DateTime.Now;

            btnUpdate.Enabled = false;
        }

        //Hàm check dữ liệu và tuổi
        public void checkField()
        {
            if (txtName.Text == "" | txtAddress.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin", "Cảnh báo");
                return;
            }

            if (checkAge(dtDob.Value) < 18)
            {
                MessageBox.Show("Người dùng dưới 18 tuổi", "Cảnh báo");
                return;
            }
            check = true;
        }

        //Hàm tính tuổi dưới 18
        public static int checkAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear > dateOfBirth.DayOfYear)
            {
                age = age - 1;
            }
            return age;
        }

        #endregion Method
    }
}
