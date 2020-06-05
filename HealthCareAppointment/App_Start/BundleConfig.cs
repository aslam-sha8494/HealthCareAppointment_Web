using System.Web;
using System.Web.Optimization;

namespace HealthCareAppointment
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js",
                         "~/Scripts/jquery-ui-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                     "~/Scripts/jquery.validate*"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/DataTables/jquery.datatables.js",
                      "~/Scripts/DataTables/datatables.bootstrap.js",
                      "~/Scripts/DataTables/dataTables.buttons.js",
                      "~/Scripts/toastr.js",
                       "~/Scripts/DataTables/jszip.js",
                      "~/Scripts/DataTables/buttons.html5.js",
                       "~/Scripts/DataTables/buttons.print.js",
                      "~/Scripts/DataTables/pdfmake.js",
                      "~/Scripts/DataTables/vfs_fonts.js"
                      ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css",
                      "~/Content/DataTables/css/buttons.dataTables.css",
                      "~/Content/toastr.css",
                      "~/Content/themes/base/jquery-ui.min.css",
                      "~/Content/themes/base/minified/jquery-ui.min.css",
                      "~/Content/Site.css"));
        }
    }
}
