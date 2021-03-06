﻿using iWebSite_ComeIndus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace iWebSite_ComeIndus.Controllers
{
    public class AccountController : _BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 登入頁面View
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 登入驗證
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(AccountModels Model)
        {
            //DB Connection
            DBC.CheckDBConnection();

            //return null;

            return View(Model);

            //return Redirect("/Account/Login");
        }
    }
}
