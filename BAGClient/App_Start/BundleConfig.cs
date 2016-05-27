using System.Web;
using System.Web.Optimization;

namespace BrewAgift
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery-1.js",
                        "~/Scripts/jquery-ui.js",
                        "~/Scripts/header.js",
                        "~/Scripts/jquery-2.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/waypoints.min.js",
                        "~/Scripts/jquery.counterup.min.js",
                        "~/Scripts/jquery.parallax-1.1.3.js",
                        "~/Scripts/front.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/custom.js"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/animate.css",
                      "~/Content/default.css",
                      "~/Content/custom.css",
                      "~/Content/style.css",
                      "~/Content/header_v3.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.theme.css"));
        }
    }
}
