﻿using _1911066023_VanThanhKhanhDuy_BigSchool.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1911066023_VanThanhKhanhDuy_BigSchool.ViewModels;

namespace _1911066023_VanThanhKhanhDuy_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbcontext;
        public HomeController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbcontext.Courses
               .Include(c => c.Lecturer)
               .Include(c => c.Category)
               .Where(c => c.DateTime > DateTime.Now);

            return View(upcommingCourses);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //nop bai 28/3/2022
    }
}