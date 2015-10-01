using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;

namespace ExtNetNoIframeDemo.Controllers
{
    public class Controller1Controller : Controller
    {
        // GET: Controller1/PartialView1
        public Ext.Net.MVC.PartialViewResult PartialView1(string containerId)
        {
            return new Ext.Net.MVC.PartialViewResult(containerId)
            {
                ClearContainer = true,
                WrapByScriptTag = false
            };
        }

        // GET: Controller1/SimulateAjax
        public ActionResult SimulateAjax()
        {
            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}