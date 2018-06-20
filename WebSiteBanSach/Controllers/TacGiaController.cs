using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteBanSach.Controllers
{
    public class TacGiaController : Controller
    {
        // GET: TacGia
        public ActionResult Index()
        {
            return View();
        }

        // GET: TacGia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TacGia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TacGia/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TacGia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TacGia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TacGia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TacGia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
