using LSOU.Web.Models.Facebook;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace LSOU.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return GetFacebookPageFeeds();
        }

        public ActionResult GetFacebookPageFeeds()
        {
            return View(
                new FBRepository().GetLatestPosts()
            );
        }
    }
}
