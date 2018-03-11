using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    class DangNhapNguoiDung
    {
        public bool DangNhap(string TenDangNhap, string MatKhau)
        {
            string str;
            str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySV24;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM QuanLyNguoiDung WHERE TenDangNhap='" + TenDangNhap + "' and MatKhau='" + MatKhau + "' and QuyenHan='admin'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
