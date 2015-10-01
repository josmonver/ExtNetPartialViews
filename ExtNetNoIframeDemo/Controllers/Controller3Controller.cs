using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;

namespace ExtNetNoIframeDemo.Controllers
{
    public class Controller3Controller : Controller
    {
        // GET: Controller3/PartialView3
        public Ext.Net.MVC.PartialViewResult PartialView3(string containerId)
        {
            return new Ext.Net.MVC.PartialViewResult(containerId)
            {
                ClearContainer = true,
                WrapByScriptTag = false
            };
        }

    }
}