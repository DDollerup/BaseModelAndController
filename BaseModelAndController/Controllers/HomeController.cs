using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseModelAndController.Models.BaseModels;

namespace BaseModelAndController.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            Site index = new Site();
            index.SiteID = 0;
            index.Text = "This is Index";
            index.Image = "placeholder.jpg";
            index.PageTitle = "Home";
            index.MetaDescription = "This is the frontpage";
            return View(index);
        }
    }
}