using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class frmThemMonHoc : Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
                SqlConnection con = new SqlConnection();
                con.ConnectionString = KetNoi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                int SoTrinh;
                int HocKy;
                SoTrinh = Convert.ToInt16(txtSoTrinh.Text);
                HocKy = Convert.ToInt16(txtHocKy.Text);
                cmd.CommandText = "INSERT INTO HOCPHAN VALUES('" + txtMaMonHoc.Text + "','" + txtTenMonHoc.Text + "','" + txtMaBoMon.Text + "'," + SoTrinh + "," + HocKy + ")";
                cmd.ExecuteNonQuery();
                DialogResult result;
                result = MessageBox.Show("THÊM DỮ LIỆU THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    frmThemMonHoc frm = new frmThemMonHoc();
                    frm.Show();
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Nhập Liệu Sai !", "Thông Báo");
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDSMonHoc frm = new frmDSMonHoc();
            frm.Show();
            
        }
    }
}
