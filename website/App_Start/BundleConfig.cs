using System.Web.Optimization;

namespace LSOU.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Resources/Scripts/jquery-{version}.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Resources/Scripts/bootstrap.js",
                "~/Resources/Scripts/respond.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                "~/Resources/Scripts/site.js")
            );

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Resources/Content/bootstrap.css",
                "~/Resources/Content/Site.css")
            );
        }
    }
}
