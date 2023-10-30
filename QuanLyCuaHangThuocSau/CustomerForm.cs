﻿using System;
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
    public partial class CustomerForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Dbconnect dbcon = new Dbconnect();
        SqlDataReader dr;
        string title = "Quản Lý Cửa Hàng Thuốc Bảo Vệ Thực Vật";
        public CustomerForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            LoadCustomer();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerModule module = new CustomerModule(this);
            module.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        //private void dgvUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModule module = new CustomerModule(this);
                module.lblCid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi này?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM tbCustomer WHERE id LIKE'" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    LoadCustomer();
                    MessageBox.Show("Xóa thành công", title, MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            }
        }

        #region Method

        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCustomer WHERE CONCAT(name, address, phone) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }

        #endregion Method


    }
}