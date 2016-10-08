using System;
using System.Web.Mvc;

namespace LSOU.Web.Controllers
{
    [AllowAnonymous]
    public abstract class ContentController : Controller
    {
        [HttpGet]
        public ActionResult Default()
        {
            Object content = GetContent();
            if (Request.IsAjaxRequest())
            {
                return content != null ? PartialView(content) : PartialView();
            }

            return content != null ? View(content) : View();
        }

        protected abstract Object GetContent();
    }

}
