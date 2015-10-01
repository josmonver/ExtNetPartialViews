using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtNetNoIframeDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public Ext.Net.MVC.PartialViewResult MainMenu1(string containerId)
        {
            return new Ext.Net.MVC.PartialViewResult(containerId)
            {
                ClearContainer = true,
                WrapByScriptTag = false
            };
        }

        public Ext.Net.MVC.PartialViewResult MainMenu2(string containerId)
        {
            return new Ext.Net.MVC.PartialViewResult(containerId)
            {
                ClearContainer = true,
                WrapByScriptTag = false
            };
        }
    }
}