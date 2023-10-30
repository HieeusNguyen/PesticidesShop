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

namespace QuanLyCuaHangThuocSau
{
    public partial class CashProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader dr;
        string title = "Quản Lý Cửa Hàng Thuốc Bảo Vệ Thực Vật";
        public string uname;

        CashForm cash;
        public CashProduct(CashForm form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cash = form;
            LoadProduct();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvProduct.Rows)
            {
                bool chkbox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if (chkbox)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO tbCash (transno, pcode, pname, qty, price, cashier) VALUES (@transno, @pcode, @pname, @qty, @price, @cashier)", cn);
                        cmd.Parameters.AddWithValue("@transno", cash.lblTransno.Text);
                        cmd.Parameters.AddWithValue("@pcode", dr.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@pname", dr.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@qty", 1);
                        cmd.Parameters.AddWithValue("@price", Convert.ToDouble(dr.Cells[5].Value.ToString()));
                        cmd.Parameters.AddWithValue("@cashier", uname);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message, title);
                    }
                }
            }
            cash.loadCash();
            this.Dispose();
        }

        private void txtSeacrh_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        #region Method

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT pcode, pname, ptype, pcategory, pprice FROM tbProduct WHERE CONCAT(pname, ptype, pcategory, pqty, pprice) LIKE '%" + txtSeacrh.Text + "%'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        #endregion Method
    }
}
