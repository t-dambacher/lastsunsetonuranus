using LSOU.Web.Models.News;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace LSOU.Web.Controllers
{
    public class ActualitesController : ContentController
    {
        protected override Object GetContent()
        {
            return null;
        }

        public ActionResult GetFacebookPageFeeds()
        {
            return View(
                NewsRepository.GetLatestPosts()
            );
        }
    }
}
