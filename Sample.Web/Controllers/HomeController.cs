using Sample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class HomeController : ContextControllerBase
    {
        private WidgetService _widgetService;

        public HomeController()
            : base()
        {
            _widgetService = new WidgetService(this.Context);
        }

        public ActionResult Index()
        {

            return View(new WidgetViewModel(_widgetService.QueryAll()));
        }
    }
}