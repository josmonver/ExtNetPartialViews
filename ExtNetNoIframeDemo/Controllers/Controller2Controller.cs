using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC;

namespace ExtNetNoIframeDemo.Controllers
{
    public class Controller2Controller : Controller
    {
        // GET: Controller2/PartialView2
        public Ext.Net.MVC.PartialViewResult PartialView2(string containerId)
        {
            return new Ext.Net.MVC.PartialViewResult(containerId)
            {
                ClearContainer = true,
                WrapByScriptTag = false
            };
        }
    }
}