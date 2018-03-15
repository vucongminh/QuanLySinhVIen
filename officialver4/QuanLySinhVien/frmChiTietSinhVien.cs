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
    public partial class frmChiTietSinhVien : Form
    {
        public static string username = string.Empty;
        public static string pass = string.Empty;
        string SinhVien_ID;
        public frmChiTietSinhVien(string MaSinhVien)
        {
            SinhVien_ID = MaSinhVien;
            InitializeComponent();
            DangNhapHeThong DangNhap = new DangNhapHeThong();
            if (DangNhap.checkOnlyRead(username, pass) == true)
            {
                Color hic = Color.FromArgb(54, 54, 54);
                
                button4.BackColor = hic;
                button4.Enabled = false;
                
            }
        }

        private void frmChiTietSinhVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM SinhVien WHERE  MaSV='" + SinhVien_ID + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            this.txtMaSinhVien.Text = td.Rows[0][0].ToString();
            this.txtHoTen.Text = td.Rows[0][1].ToString();
            this.txtCMND.Text = td.Rows[0][2].ToString();
            DateTime ngay = DateTime.Parse(td.Rows[0][4].ToString());
            this.mskNgaySinh.Text = ngay.ToString("dd-MM-yyyy");
            
            this.txtQueQuan.Text = td.Rows[0][5].ToString();
            this.txtSDT.Text = td.Rows[0][6].ToString();
            this.txtTenLop.Text = td.Rows[0][7].ToString();
            string hinhanh;
            hinhanh = td.Rows[0][8].ToString();
            if(hinhanh.Length<=0)
            {
                this.pictureBox1.Image = new Bitmap(Application.StartupPath + @"\hinhanh\vodien.jpg" );
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                this.pictureBox1.Image = new Bitmap(Application.StartupPath + @"\hinhanh\" + hinhanh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            int sex;
            sex = Convert.ToInt16(td.Rows[0][3]);
            if (sex == 0)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frm = new frmKetQuaHocTap(SinhVien_ID);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuaThongTinSinhVien frm = new frmSuaThongTinSinhVien(SinhVien_ID);
            frm.Show();
        }
        private void txtMaSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
