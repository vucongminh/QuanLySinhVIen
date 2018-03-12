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
    public partial class frmSuaThongTinSinhVien : Form
    {
        string SinhVien_ID;
        string hinhanh;
        public frmSuaThongTinSinhVien(string MaSinhVien)
        {
            SinhVien_ID = MaSinhVien;
            InitializeComponent();
        }

        private void frmSuaThongTinSinhVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SinhVien.*,Lop.TenLop FROM SinhVien,Lop WHERE MaSV='" + SinhVien_ID + "' and SinhVien.MaLop=Lop.MaLop";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            this.txtMaSinhVien.Text = td.Rows[0][0].ToString();
            this.txtCMND.Text = td.Rows[0][2].ToString();
            DateTime ngay = DateTime.Parse(td.Rows[0][4].ToString());
            this.maskedTextBox1.Text = ngay.ToString("dd-MM-yyyy");           
            this.txtQueQuan.Text = td.Rows[0][5].ToString();
            this.txtSDT.Text = td.Rows[0][6].ToString();
            this.txtTen.Text = td.Rows[0][1].ToString();
            this.cboLop.Text = td.Rows[0][10].ToString();
            string hinhanh;
            hinhanh = td.Rows[0][8].ToString();
            if (hinhanh.Length <= 0)
            {
                this.pictureBox1.Image = new Bitmap(Application.StartupPath + @"\hinhanh\vodien.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
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

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = KetNoi.str;
            con2.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con2;
            cmd2.CommandText = "SELECT * FROM Lop order by MaLop ";
            SqlDataReader rd2;
            rd2 = cmd2.ExecuteReader();
            DataTable td2 = new DataTable();
            td2.Load(rd2);
            for (int i = 0; i < td2.Rows.Count; i++)
            {
                this.cboLop.Items.Add(td2.Rows[i][1]);
            }
            con2.Close();
        
    }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChiTietSinhVien frm = new frmChiTietSinhVien(SinhVien_ID);
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            int sex;
            if (radioButton1.Checked == true)
                sex = 0;
            else
                sex = 1;
            try{
                string TenLop = cboLop.SelectedItem.ToString();
                cmd.CommandText = "select MaLop from Lop where TenLop =N'" + TenLop + "'";
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                DataTable td = new DataTable();
                td.Load(rd);
                string MaLop = td.Rows[0][0].ToString();
                cmd.CommandText = "UPDATE SinhVien SET CMND='" + txtCMND.Text + "',GioiTinh=" + sex + ",NgaySinh='" + DateTime.Parse(maskedTextBox1.Text) + "',QueQuan=N'" + txtQueQuan.Text + "',SdtSV='" + txtSDT.Text + "',TenSV=N'" + txtTen.Text + "',MaLop='" + MaLop + "',HinhAnh='" + hinhanh + "'WHERE MaSV='" + SinhVien_ID + "'";
                DialogResult result;
                result = MessageBox.Show("BẠN CÓ MUỐN THAY ĐỔI THÔNG TIN KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CẬP NHẬT THÀNH CÔNG", "THÔNG BÁO");
                }
                con.Close();
                this.Close();
                frmChiTietSinhVien frm = new frmChiTietSinhVien(SinhVien_ID);
                frm.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập..Có thể bạn quên chưa nhập 1 trường nào đó ^^!", "Thông Báo !");
            }
                     
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.InitialDirectory = Application.StartupPath + @"hinhanh/";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                hinhanh = dl.FileName.Substring(dl.FileName.LastIndexOf("\\") + 1, dl.FileName.Length - dl.FileName.LastIndexOf("\\") - 1);
                pictureBox1.Image = new Bitmap(Application.StartupPath + @"\hinhanh\" + hinhanh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnKetQuaHocTap_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frm = new frmKetQuaHocTap(SinhVien_ID);
            frm.Show();
        }
    }
}
