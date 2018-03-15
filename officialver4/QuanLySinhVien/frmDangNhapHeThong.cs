using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDangNhapHeThong : Form
    {
        public frmDangNhapHeThong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhapHeThong DangNhap = new DangNhapHeThong();
            if (DangNhap.LoginHeThong(txtTenDangNhap.Text, txtMatKhau.Text) == true)
            {
                frmMain Main = (frmMain)this.MdiParent;
                if (DangNhap.checkAdmin(txtTenDangNhap.Text, txtMatKhau.Text) == true)
                {
                   Main.EnableMenu(); }
                else if (DangNhap.checkOnlyRead(txtTenDangNhap.Text, txtMatKhau.Text) == true)
                {
                    Main.MenuForOnlyRead();
                } else { Main.MenuForOnlyRead(); }
                    
                
                MessageBox.Show("Đăng Nhập Thành Công","Thông Báo");
                frmDSSV.username = txtTenDangNhap.Text;
                frmDSSV.pass = txtMatKhau.Text;

                frmKhoa.username = txtTenDangNhap.Text;
                frmKhoa.pass = txtMatKhau.Text;

                frmDSMonHoc.username = txtTenDangNhap.Text;
                frmDSMonHoc.pass = txtMatKhau.Text;

                frmDSLop.username = txtTenDangNhap.Text;
                frmDSLop.pass = txtMatKhau.Text;

                frmKetQuaHocTap.username = txtTenDangNhap.Text;
                frmKetQuaHocTap.pass = txtMatKhau.Text;

                frmChiTietSinhVien.username = txtTenDangNhap.Text;
                frmChiTietSinhVien.pass = txtMatKhau.Text;
                this.Close();
                
            }
            else
                MessageBox.Show("Thông Tin Đăng Nhập Không Đúng.Vui Lòng Kiểm Tra Lại", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
    }
}
