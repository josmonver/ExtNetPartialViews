using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ExtNetNoIframeDemo.Controllers
{
    public class DialogController : Controller
    {
        // GET: Dialog/Index
        public Ext.Net.MVC.PartialViewResult Index(string containerId)
        {
            return new Ext.Net.MVC.PartialViewResult(containerId)
            {
                ClearContainer = true,
                WrapByScriptTag = false,
                ViewName = "_Dialog"
            };
        }
    }
}