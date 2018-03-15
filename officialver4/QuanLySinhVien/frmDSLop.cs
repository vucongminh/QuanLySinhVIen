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
    public partial class frmDSLop : Form
    {
        public static string username = string.Empty;
        public static string pass = string.Empty;
        public frmDSLop()
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

        private void frmDSLop_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Lop.MaLop,TenLop,TenSV,TenGV FROM LOP ,SINHVIEN , GIAOVIEN  where LOP.MaLopTruong=SINHVIEN.MaSV and LOP.MaGVCN=GIAOVIEN.MaGV ";
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
                listView1.Items.Add(item);

            }
            con.Close();

        }

       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            frmSuaLop frm = new frmSuaLop(str);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmThemLop frm = new frmThemLop();
            //frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                int row = this.listView1.SelectedItems[0].Index;
                str = this.listView1.Items[row].SubItems[0].Text;
                this.Close();
                frmSuaLop frm = new frmSuaLop(str);
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception )
            {
                MessageBox.Show("Hay Chon Sinh Vien Muon Sua !","Thong Bao");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
            string str;
            int row = this.listView1.SelectedItems[0].Index;
            str = this.listView1.Items[row].SubItems[0].Text;
            this.Close();
            frmXoaLop frm = new frmXoaLop(str);
                //frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay Chon Sinh Vien Muon Sua !", "Thong Bao");
            }
        }
    }
}
