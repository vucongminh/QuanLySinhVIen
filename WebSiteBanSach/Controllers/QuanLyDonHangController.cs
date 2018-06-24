using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;

namespace WebSiteBanSach.Controllers
{
    public class QuanLyDonHangController : Controller
    {
        // GET: QuanLyDonHang
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
                    var result = db.DonHangs.AsEnumerable().Where(s => s.MaDonHang.ToString().Contains(SearchText));
                    return View(result.ToList().OrderBy(n => n.MaDonHang).ToPagedList(pageNumber, pageSize = 100));

                }

                else
                {
                    var result = db.DonHangs.Where(s => s.MaKH.ToString().Contains(SearchText));
                    return View(result.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize = 100));
                }

            }

            return View(db.DonHangs.ToList().OrderBy(n => n.MaDonHang).ToPagedList(pageNumber, pageSize));
            // return View();
        }
        //Hiển thị sản phẩm
        public ActionResult HienThi(int MaDonHang)
        {

            //Lấy ra đối tượng đơn hàng theo mã 
            DonHang DonHang = db.DonHangs.SingleOrDefault(n => n.MaDonHang == MaDonHang);
            if (DonHang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<ChiTietDonHang> lsChiTietDonHang=db.ChiTietDonHangs.Where(n => n.MaDonHang == MaDonHang).OrderBy(n => n.MaSach).ToList();
            if (lsChiTietDonHang.Count == 0)
            {
                ViewBag.SoSach = "Không có sách nào trong đơn này";
            }
            ViewBag.lsSach = lsChiTietDonHang;
            return View(DonHang);

        }
        //Chỉnh sửa sản phẩm
        [HttpGet]
        public ActionResult ChinhSua(int MaDonHang)
        {
            //Lấy ra đối tượng sách theo mã 
            DonHang don = db.DonHangs.SingleOrDefault(n => n.MaDonHang == MaDonHang);
            if (don == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            
            return View(don);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(DonHang don, FormCollection f)
        {
            //Thêm vào cơ sở dữ liệu
            if (ModelState.IsValid)
            {
                //Thực hiện cập nhận trong model
                db.Entry(don).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }           
            return RedirectToAction("Index");

        }
        // GET: NhaXuatBan/Delete/5
        public ActionResult Xoa(int MaDonHang)
        {
            DonHang don = db.DonHangs.SingleOrDefault(n => n.MaDonHang == MaDonHang);
            if (don == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(don);
            //return View();
        }

        // POST: NhaXuatBan/Delete/5
        [HttpPost, ActionName("Xoa")]
        public ActionResult XacNhanXoa(int MaDonHang, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                DonHang don = db.DonHangs.SingleOrDefault(n => n.MaDonHang == MaDonHang);
                if (don == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                List<ChiTietDonHang> lsChiTietDonHang = db.ChiTietDonHangs.Where(n => n.MaDonHang == MaDonHang).ToList();
                db.ChiTietDonHangs.RemoveRange(lsChiTietDonHang);
                db.DonHangs.Remove(don);
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