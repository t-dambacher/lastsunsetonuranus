using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LSOU.Web.Views
{
    public class ContentViewEngine : RazorViewEngine
    {
        const String DEFAULT_CONTENT_VIEW_NAME = "Default";
        const String DEFAULT_CONTENT_VIEW_PATH = "~/Views/Shared/Default.cshtml";

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            if (IsContentView(partialViewName))
            {
                return new ViewEngineResult(
                    CreatePartialView(controllerContext, DEFAULT_CONTENT_VIEW_PATH), this
                );
            }

            return base.FindPartialView(controllerContext, partialViewName, useCache);
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (IsContentView(viewName))
            {
                return new ViewEngineResult(
                    CreateView(controllerContext, DEFAULT_CONTENT_VIEW_PATH, null), this
                );
            }

            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

        private Boolean IsContentView(String viewName)
        {
            return DEFAULT_CONTENT_VIEW_NAME.Equals(viewName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
