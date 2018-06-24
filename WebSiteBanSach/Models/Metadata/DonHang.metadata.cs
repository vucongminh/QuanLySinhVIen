﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebSiteBanSach.Models
{
    [MetadataTypeAttribute(typeof(DonHangMetadata))]
    public partial class DonHang
    {
        internal sealed class DonHangMetadata
        {
            [Display(Name = "Mã Đơn hàng: ")]
            public int MaDonHang { get; set; }
            [Display(Name = "Ngày giao: ")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public Nullable<System.DateTime> NgayGiao { get; set; }
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [Display(Name = "Ngày đặt: ")]
            public Nullable<System.DateTime> NgayDat { get; set; }
            [Display(Name = "Đã thanh toán: ")]
            public string DaThanhToan { get; set; }
            [Display(Name = "Tình trạng giao hàng: ")]
            public Nullable<int> TinhTrangGiaoHang { get; set; }
            [Display(Name = "Mã KH: ")]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
            public Nullable<int> MaKH { get; set; }
        }
    }
}