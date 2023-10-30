using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangThuocSau
{
    public partial class CashForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader dr;
        string title = "Quản Lý Cửa Hàng Thuốc Bảo Vệ Thực Vật";
        MainForm main;
        public CashForm(MainForm form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            main = form;
            getTransno();
            loadCash();
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CashProduct product = new CashProduct(this);
            product.uname = main.lblUsername.Text;
            product.ShowDialog();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        #region Method

        public void getTransno()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;

                cn.Open();
                cmd = new SqlCommand("SELECT TOP 1 transno FROM tbCash WHERE transno LIKE  '"+ sdate +"%' ORDER BY cashid DESC ", cn);
                dr = cmd.ExecuteReader();
                dr.Read();

                if(dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8,4));
                    lblTransno.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex) 
            { 
                cn.Close() ;
                MessageBox.Show(ex.Message, title);
            }
           
        }

        public void loadCash()
        {
            try
            {
                int i = 0;
                dgvCash.Rows.Clear();
                cmd = new SqlCommand("SELECT cashid, pcode,pname,qty, price, total, c.name, cashier FROM tbCash as cash LEFT JOIN tbCustomer c on cash.cid = c.id WHERE transno LIKE "+lblTransno.Text+"", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCash.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message, title);
            }
        }

        #endregion Method
    }
}
