using BaseModelAndController.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BaseModelAndController.Controllers
{
    public class BaseController : Controller
    {
        List<Site> sites = new List<Site>();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sites.Add(new Site()
            {
                SiteID = 1,
                Text = "This is my first Dynamic Web Page",
                Image = "placeholder.jpg",
                PageTitle = "First Dynamic Web Page",
                MetaDescription = "I can create Dynamic Web Pages"
            });

            sites.Add(new Site()
            {
                SiteID = 2,
                Text = "This is my second Dynamic Web Page",
                Image = "placeholder.jpg",
                PageTitle = "Second Dynamic Web Page",
                MetaDescription = "I can create Dynamic Web Pages, again"
            });

            ViewBag.Sites = sites;

            base.OnActionExecuting(filterContext);
        }

        public ActionResult Site(int id)
        {
            Site siteToGet = sites.Find(x => x.SiteID == id);
            return View(siteToGet);
        }
    }
}