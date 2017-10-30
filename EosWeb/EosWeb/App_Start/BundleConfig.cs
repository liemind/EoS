using System.Web;
using System.Web.Optimization;

namespace EosWeb
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/raphael.min.js",
                      "~/Scripts/morris.min.js",
                      "~/Scripts/jquery.sparkline.min.js",
                      "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/jquery-jvectormap-world-mill-en.min.js",
                      "~/Scripts/jquery.knob.min.js",
                      "~/Scripts/bootstrap3-wysihtml5.all.min.js",
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/adminlte.min.js",
                      "~/Scripts/dashboard.js",
                      "~/Scripts/demo.js"
                      ));


            bundles.Add(new ScriptBundle("~/bundles/tables").Include(
                        "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/cssTables").Include(
                      "~/Content/dataTables.bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/Content/ionicons").Include(
                      "~/Content/ionicons.min.css"));
            bundles.Add(new StyleBundle("~/Content/adminLTE").Include(
                      "~/Content/AdminLTE.min.css"));
            bundles.Add(new StyleBundle("~/Content/extra").Include(
                      "~/Content/_all-skins.min.css",
                      "~/Content/jquery-jvectormap.css",
                      "~/Content/"));
        }
    }
}
