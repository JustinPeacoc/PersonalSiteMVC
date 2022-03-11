using System.Web;
using System.Web.Optimization;

namespace PersonalSiteMVC.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/_OriginalScripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/templateScripts").Include(
                     "~/Content/assets/vendor/purecounter/purecounter.js", "~/Content/assets/vendor/aos/aos.js", "~/Content/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                     "~/Content/assets/vendor/glightbox/js/glightbox.min.js", "~/Content/assets/vendor/isotope-layout/isotope.pkgd.min.js", "~/Content/assets/vendor/swiper/swiper-bundle.min.js",
                     "~/Content/assets/vendor/typed.js/typed.min.js", "~/Content/assets/vendor/waypoints/noframework.waypoints.js", "~/Content/assets/vendor/php-email-form/validate.js", "~/Content/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/vendor/aos/aos.css",
                      "~/Content/assets/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/assets/vendor/bootstrap-icons/bootstrap-icons.css", "~/Content/assets/vendor/boxicons/css/boxicons.min.css", "~/Content/assets/vendor/glightbox/css/glightbox.min.css",
                      "~/Content/assets/vendor/swiper/swiper-bundle.min.css", "~/Content/css/style.css"));
            
        }
    }
}
