﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAngEF.Models;
using WebApplicationAngEF.Services;

namespace WebApplicationAngEF.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mailService;

        public HomeController(IMailService mailService)
        {
            _mailService = mailService;

        }
        public ActionResult Index()
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

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            var msg = string.Format("Comment From: {1}{0}Email:{2}{0}Website:{3}{0}Message:{4}{0}",
                Environment.NewLine, model.Name, model.Email, model.Website, model.Comment);

            if (_mailService.SendMail("noreply@yourdomain.com",
                "foo@yourdomain.com", "Website contact", msg))
            {
                ViewBag.MailSent = true;
            }
            return View();
        }

    }
}