﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;
using PagedList;
using PagedList.Mvc;

namespace WebSiteBanSach.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        public ActionResult Index(int? page)
        {
            //Tạo biến số sản phẩm trên trang
            int pageSize = 9;
            //Tạo biến số trang
            int pageNumber = (page ?? 1);
            return View(db.Saches.Where(n=>n.Moi==1).OrderBy(n=>n.GiaBan).ToPagedList(pageNumber,pageSize));
        }
       
	}
}