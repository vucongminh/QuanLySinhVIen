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
    public partial class frmThemKetQua : Form
    {
        string SinhVien_ID;
        public frmThemKetQua(string MaSinhVien)
        {
            SinhVien_ID = MaSinhVien;
            InitializeComponent();
        }

        private void frmThemKetQua_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT TenHP FROM HocPhan  order by MaHP ";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            for (int i = 0; i < td.Rows.Count; i++)
            {
                this.cboMonHoc.Items.Add(td.Rows[i][0]);
            }
                   
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string TenMonHoc;
            TenMonHoc = cboMonHoc.SelectedItem.ToString();
            cmd.CommandText = "select* from HOCPHAN where TenHP =N'" + TenMonHoc + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            string MaMonHoc = td.Rows[0][0].ToString();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "SELECT MaLHP FROM HOCPHAN as h,LOPHOCPHAN as l where h.TenHP=N'" + TenMonHoc + "'and l.MaHP=h.MaHP";
            SqlDataReader rd2;
            rd2 = cmd2.ExecuteReader();
            DataTable td2 = new DataTable();
            td2.Load(rd2);
            for (int i = 0; i < td2.Rows.Count; i++)
            {
                this.cbLHP.Items.Add(td2.Rows[i][0]);
            }
            string MaLHP = cbLHP.SelectedItem.ToString();
            int LanThi;
            LanThi = Convert.ToInt16(txtLanThi.Text);
            double DiemCC;
            DiemCC = Convert.ToDouble(txtDiemCC.Text);
            double TX;
            TX = Convert.ToDouble(txtDiemTX.Text);
            double Thi;
            Thi = Convert.ToDouble(txtDiemThi.Text);
            double TB;
            TB = Convert.ToDouble(txtDiemTB.Text);
            string GhiChu;
            GhiChu = cbGhiChu.SelectedItem.ToString();
            cmd.CommandText = "INSERT INTO BANGDIEM VALUES('" + SinhVien_ID + "','" +MaLHP+ "'," + TX + "," + Thi + "," + TB + ","+LanThi+","+GhiChu+")";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm Dữ Liệu Thành Công!");
            this.Close();
            frmKetQuaHocTap frm = new frmKetQuaHocTap(SinhVien_ID);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmKetQuaHocTap frm = new frmKetQuaHocTap(SinhVien_ID);
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
