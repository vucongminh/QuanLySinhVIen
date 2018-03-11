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
    public partial class frmXoaLop : Form
    {
        //string Khoa_ID;
        string MaLop;

        public frmXoaLop(string Ma)
        {
            //Khoa_ID = MaKhoa;
            MaLop = Ma;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDSLop frm = new frmDSLop();
            frm.Show();
        }

        private void frmXoaLop_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT TenLop FROM LOP WHERE MaLop='" + MaLop + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            this.txtMaLop.Text = MaLop;
            this.txtTenLop.Text = td.Rows[0][0].ToString();
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = KetNoi.str;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM LOP Where MaLop='" + MaLop + "'";
                DialogResult result;
                result = MessageBox.Show("BẠN CÓ MUỐN XÓA THÔNG TIN KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("XÓA THÀNH CÔNG", "THÔNG BÁO");
                    this.Close();
                    frmDSLop frm = new frmDSLop();
                    frm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập Liệu Sai !", "Thông Báo");
            }

        }
    }
}
