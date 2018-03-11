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
    public partial class frmKhoa : Form
    {
        public static string username = string.Empty;
        public static string pass = string.Empty;
        public frmKhoa()
        {
            InitializeComponent();
            DangNhapHeThong DangNhap = new DangNhapHeThong();
            if (DangNhap.checkOnlyRead(username, pass) == true)
            {
                Color hic = Color.FromArgb(54, 54, 54);
                btnSua.BackColor = hic;
                btnSua.Enabled = false;
                btnThem.BackColor = hic;
                btnThem.Enabled = false;
                btnXoa.BackColor = hic;
                btnXoa.Enabled = false;
            }
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM BOMON";
            cmd.CommandText = "SELECT BOMON.MaBM, TenBM, TenGV FROM BOMON, GIAOVIEN where BOMON.MaChuNhiemBM=GIAOVIEN.MaGV";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            for (int i = 0; i < td.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                item.SubItems.Add(td.Rows[i][1].ToString());
                item.SubItems.Add(td.Rows[i][2].ToString());
                listView1.Items.Add(item);

            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmThemKhoa frm = new frmThemKhoa();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            frmSuaKhoa frm = new frmSuaKhoa(str);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                int row = this.listView1.SelectedItems[0].Index;
                str = this.listView1.Items[row].SubItems[0].Text;
                frmSuaKhoa frm = new frmSuaKhoa(str);
                //frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy Chọn Bộ Môn Muốn Sửa !", "Thông Báo ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                int row = this.listView1.SelectedItems[0].Index;
                str = this.listView1.Items[row].SubItems[0].Text;
                frmXoaKhoa frm = new frmXoaKhoa(str);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy Chọn Bộ Môn Muốn Xóa !", "Thông Báo ");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
