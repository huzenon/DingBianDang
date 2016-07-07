using System.Web.Optimization;

namespace DingBianDangWeb
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/base/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/_Layout.css"
                ));

            bundles.Add(new ScriptBundle("~/base/js/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.blockUI.js"
                ));

            bundles.Add(new ScriptBundle("~/base/js/bootstrap").Include(
                "~/Scripts/bootstrap.js"
                ));
        }
    }
}
