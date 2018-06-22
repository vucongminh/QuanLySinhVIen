using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;

namespace WebSiteBanSach.Controllers
{
    public class QuanLyKhachHangController : Controller
    {
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        public ActionResult Index(int? page, string SearchText)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            int parsedValue;
            if (!string.IsNullOrEmpty(SearchText))
            {
                if (Int32.TryParse(SearchText, out parsedValue))
                {
                    var result = db.KhachHangs.AsEnumerable().Where(s => s.MaKH.ToString().Contains(SearchText));
                    return View(result.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize = 100));

                }

                else
                {
                    var result = db.KhachHangs.Where(s => s.HoTen.Contains(SearchText));
                    return View(result.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize = 100));
                }

            }

            return View(db.KhachHangs.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize));
            // return View();
        }
    }
}