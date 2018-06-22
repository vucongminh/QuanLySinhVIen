using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;

namespace WebSiteBanSach.Controllers
{
    public class QuanLyNXBController : Controller
    {
        // GET: QuanLyNXB
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
                    var result = db.NhaXuatBans.AsEnumerable().Where(s => s.MaNXB.ToString().Contains(SearchText));
                    return View(result.ToList().OrderBy(n => n.MaNXB).ToPagedList(pageNumber, pageSize = 100));

                }

                else
                {
                    var result = db.NhaXuatBans.Where(s => s.TenNXB.Contains(SearchText));
                    return View(result.ToList().OrderBy(n => n.MaNXB).ToPagedList(pageNumber, pageSize = 100));
                }

            }

            return View(db.NhaXuatBans.ToList().OrderBy(n => n.MaNXB).ToPagedList(pageNumber, pageSize));
        }
        // GET: NhaXuatBan/Details/5
        public ActionResult HienThi(int maNXB)
        {
            NhaXuatBan NhaXuatBan = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == maNXB);
            if (NhaXuatBan == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(NhaXuatBan);
            //return View();
        }
        // GET: NhaXuatBan/Create
        public ActionResult ThemMoi()
        {
            return View();
        }

        // POST: NhaXuatBan/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(NhaXuatBan NhaXuatBan, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.NhaXuatBans.Add(NhaXuatBan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: NhaXuatBan/Edit/5
        public ActionResult ChinhSua(int maNXB)
        {
            NhaXuatBan NhaXuatBan = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == maNXB);
            if (NhaXuatBan == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(NhaXuatBan);
        }

        // POST: NhaXuatBan/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(NhaXuatBan NhaXuatBan, FormCollection f)
        {
            try
            {
                // TODO: Add update logic here
                //Thêm vào cơ sở dữ liệu
                if (ModelState.IsValid)
                {
                    //Thực hiện cập nhận trong model
                    db.Entry(NhaXuatBan).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: NhaXuatBan/Delete/5
        public ActionResult Xoa(int maNXB)
        {
            NhaXuatBan NhaXuatBan = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == maNXB);
            if (NhaXuatBan == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(NhaXuatBan);
            //return View();
        }

        // POST: NhaXuatBan/Delete/5
        [HttpPost, ActionName("Xoa")]
        public ActionResult XacNhanXoa(int maNXB, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                NhaXuatBan NhaXuatBan = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == maNXB);
                if (NhaXuatBan == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                db.NhaXuatBans.Remove(NhaXuatBan);
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