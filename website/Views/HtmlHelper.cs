using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class ViewsHtmlHelper
    {
        public static String CurrentView(this HtmlHelper html)
        {
            const String defaultValue = "_Actualites";
            if (HttpContext.Current == null || HttpContext.Current.Request == null || HttpContext.Current.Request.Url == null)
                return defaultValue;

            String localPath = HttpContext.Current.Request.Url.LocalPath;
            if (localPath == "/")
                return defaultValue;

            String[] parts = localPath.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0)
                return defaultValue;

            return "_" + parts[0];
        }
    }
}
