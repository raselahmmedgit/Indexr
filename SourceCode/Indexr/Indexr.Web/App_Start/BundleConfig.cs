using System.Web;
using System.Web.Optimization;

namespace Indexr.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.9.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-1.9.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.6.2.js"));

            // Kendo UI JS Files
            bundles.Add(new ScriptBundle("~/bundles/Kendo/js").Include(
                        "~/Scripts/Kendo/kendo.web.min.js",
                        "~/Scripts/Kendo/kendo..aspnetmvc.min.js"));

            // Application Default Theme CSS Files
            bundles.Add(new StyleBundle("~/App_Theme/Default/css").Include(
                        "~/App_Themes/Default/main.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.all.css"));

            bundles.Add(new StyleBundle("~/Content/App/css").Include(
                "~/Content/App/app.css"));

            // Kendo UI CSS Files
            bundles.Add(new StyleBundle("~/Content/Kendo/css").Include(
                "~/Content/Kendo/kendo.common.min.css",
                "~/Content/Kendo/kendo.default.min.css"));
        }
    }
}