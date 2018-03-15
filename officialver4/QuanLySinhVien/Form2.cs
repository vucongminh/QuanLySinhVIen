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
    public partial class frmDSSV : Form
    {
        public static string username = string.Empty;
        public static string pass = string.Empty;
        string MaLop;
        public frmDSSV(string Ma)
        {
            MaLop = Ma;
            InitializeComponent();
            DangNhapHeThong DangNhap = new DangNhapHeThong();
            if (DangNhap.checkOnlyRead(username, pass) == true)
            {
                Color hic = Color.FromArgb(54, 54, 54);
                button1.BackColor = hic;
                button1.Enabled = false;
                button2.BackColor = hic;
                button2.Enabled = false;
                button3.BackColor = hic;
                button3.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT MaSV,TenSV,CMND,GioiTinh,NgaySinh,QueQuan,SdtSV,TenLop FROM SINHVIEN,LOP WHERE SINHVIEN.MaLop = '" + MaLop + "' and LOP.MaLop = '" + MaLop + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            for (int i = 0; i < td.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                item.SubItems.Add(td.Rows[i][1].ToString());
                item.SubItems.Add(td.Rows[i][2].ToString());
                if (Convert.ToInt16(td.Rows[i][3]) == 0)
                    item.SubItems.Add("Nam");
                else
                    item.SubItems.Add("Nu");
                item.SubItems.Add(td.Rows[i][4].ToString());
                item.SubItems.Add(td.Rows[i][5].ToString());
                item.SubItems.Add(td.Rows[i][6].ToString());
                item.SubItems.Add(td.Rows[i][7].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemSV frmthem = new frmThemSV(MaLop);
            frmthem.Show();

            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChonLop frm = new frmChonLop();
            frm.Show();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void listView1_Click(object sender, EventArgs e)
        {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            frmsuaSV frm = new frmsuaSV(str, MaLop);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string str;
                int row = this.listView1.SelectedItems[0].Index;
                str = this.listView1.Items[row].SubItems[0].Text;
                frmsuaSV frm = new frmsuaSV(str, MaLop);
                frm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn một hàng bạn muốn thao tác ^^!", "THÔNG BÁO");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                int row = this.listView1.SelectedItems[0].Index;
                str = this.listView1.Items[row].SubItems[0].Text;
                frmxoaSV frm = new frmxoaSV(str, MaLop);
                frm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn một hàng bạn muốn thao tác ^^!", "THÔNG BÁO");
            }

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                int row = this.listView1.SelectedItems[0].Index;
                str = this.listView1.Items[row].SubItems[0].Text;
                frmChiTietSinhVien frm = new frmChiTietSinhVien(str);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn một hàng bạn muốn thao tác ^^!", "THÔNG BÁO");
            }
        }
    }
}
