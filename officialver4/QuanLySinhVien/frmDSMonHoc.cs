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
    public partial class frmDSMonHoc : Form
    {
        public static string username = string.Empty;
        public static string pass = string.Empty;
        public frmDSMonHoc()
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

        private void frmDSMonHoc_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT MaHP,TenHP,SoTC,HocKy,TenBM FROM HOCPHAN,BOMON where HOCPHAN.MaBM=BOMON.MaBM";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable td = new DataTable();
            td.Load(rd);
            for (int i = 0; i < td.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(td.Rows[i][0].ToString());
                item.SubItems.Add(td.Rows[i][1].ToString());
                item.SubItems.Add(td.Rows[i][2].ToString());
                item.SubItems.Add(td.Rows[i][3].ToString());
                item.SubItems.Add(td.Rows[i][4].ToString());
                listView1.Items.Add(item);

            }
            con.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmThemMonHoc frm = new frmThemMonHoc();
            
            frm.Show();
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            frmSuaMonHoc frm = new frmSuaMonHoc(str);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            this.Close();
            frmSuaMonHoc frm = new frmSuaMonHoc(str);
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            this.Close();
            frmXoaMonHoc frm = new frmXoaMonHoc(str);
            frm.Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
