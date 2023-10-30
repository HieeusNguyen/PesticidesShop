using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCuaHangThuocSau
{
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        string title = "Quản Lý Cửa Hàng Thuốc Bảo Vệ Thực Vật";

        bool check = false;
        ProductForm product;

        public ProductModule(ProductForm form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            product = form;
            cbCategory.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này không?", "Thêm Sản Phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("INSERT INTO tbProduct (pname, ptype, pcategory, pqty, pprice) VALUES(@pname, @ptype, @pcategory, @pqty, @pprice", cn);
                        cmd.Parameters.AddWithValue("@pname", txtNameProduct.Text);
                        cmd.Parameters.AddWithValue("@ptype", txtType.Text);
                        cmd.Parameters.AddWithValue("@pcategory", cbCategory.Text);
                        cmd.Parameters.AddWithValue("@pqty", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@pprice", txtPrice.Text);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Thêm Sản Phẩm Thành Công!", title);
                        Clear();
                        product.LoadProduct();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này không?", "Sửa Sản Phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("UPDATE tbProduct SET pname=@pname, ptype=@ptype, pcategory=@pcategory, pqty=@pqty, pprice=@pprice WHERE pcode=@pcode", cn);
                        cmd.Parameters.AddWithValue("@pcode", lblPcode.Text);
                        cmd.Parameters.AddWithValue("@pname", txtNameProduct.Text);
                        cmd.Parameters.AddWithValue("@ptype", txtType.Text);
                        cmd.Parameters.AddWithValue("@pcategory", cbCategory.Text);
                        cmd.Parameters.AddWithValue("@pqty", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@pprice", txtPrice.Text);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Sửa Sản Phẩm Thành Công!", title);
                        product.LoadProduct();
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



        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region Method

        public void Clear()
        {
            txtNameProduct.Clear();
            txtType.Clear();
            cbCategory.SelectedIndex = 0;
            txtQty.Clear();
            txtPrice.Clear();

            btnUpdate.Enabled = false;
        }

        public void checkField()
        {
            if (txtNameProduct.Text == "" | txtPrice.Text == "" | txtQty.Text == "" | txtType.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin", "Cảnh báo");
                return;
            }


            check = true;
        }
        #endregion Method
    }
}
