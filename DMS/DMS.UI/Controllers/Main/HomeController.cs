using AutoMapper;
using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.Repositories.MainRepo;
using DMS.DAL.StaticHelper;
using DMS.Services.General.Interface;
using DMS.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;

        public HomeController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        SystemInfoForSession systemSession = SessionHelper.GetSession();

        public ActionResult AccessDeniedPage()
        {
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult accfavads()
        {
            return View();
        }
        public ActionResult accmyads()
        {
            return View();
        }
        public ActionResult accprofilesetting()
        {
            return View();
        }
        public ActionResult adlistinglist()
        {
            return View();
        }
        public ActionResult adsdetails()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
        public ActionResult category()
        {
            return View();
        }
       
        public ActionResult faq()
        {
            return View();
        }
        public ActionResult forgotpass()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult offermessages()
        {
            return View();
        }
        public ActionResult payments()
        {
            return View();
        }
        public ActionResult postads()
        {
            return View();
        }
        public ActionResult pricing()
        {
            return View();
        }
        public ActionResult privacysetting()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
        public ActionResult services()
        {
            return View();
        }
        public ActionResult singlepost()
        {
            return View();
        }
        public ActionResult testimonial()
        {
            return View();
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
        public ActionResult dashboard()
        {
            return View();
        }
       

    }
}