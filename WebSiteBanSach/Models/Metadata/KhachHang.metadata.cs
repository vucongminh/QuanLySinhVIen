using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSiteBanSach.Models
{
    [MetadataTypeAttribute(typeof(KhachHangMetadata))]
    public partial class KhachHang
    {
        internal sealed class KhachHangMetadata
        {
            [Display(Name = "Mã KH: ")]
            public int MaKH { get; set; }
            [Display(Name = "Tên KH: ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string HoTen { get; set; }
            [Display(Name = "Ngày sinh: ")]
            public Nullable<System.DateTime> NgaySinh { get; set; }
            public string GioiTinh { get; set; }
            [Display(Name = "Điện thoại: ")]
            public string DienThoai { get; set; }
            [Display(Name = "Tài khoản: ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string TaiKhoan { get; set; }

            [Display(Name = "Nật khẩu: ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string MatKhau { get; set; }
            [Display(Name = "Email: ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public string Email { get; set; }
            [Display(Name = "Địa chỉ: ")]
            public string DiaChi { get; set; }

        }
    }
}