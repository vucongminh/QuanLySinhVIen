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
        // GET: KhachHang/Details/5
        public ActionResult HienThi(int maKH)
        {
            KhachHang KhachHang = db.KhachHangs.SingleOrDefault(n => n.MaKH == maKH);
            if (KhachHang == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(KhachHang);
            //return View();
        }
        // GET: KhachHang/Delete/5
        public ActionResult Xoa(int maKH)
        {
            KhachHang KhachHang = db.KhachHangs.SingleOrDefault(n => n.MaKH == maKH);
            if (KhachHang == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(KhachHang);
            //return View();
        }

        // POST: KhachHang/Delete/5
        [HttpPost, ActionName("Xoa")]
        public ActionResult XacNhanXoa(int maKH, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                KhachHang KhachHang = db.KhachHangs.SingleOrDefault(n => n.MaKH == maKH);
                if (KhachHang == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                db.KhachHangs.Remove(KhachHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}