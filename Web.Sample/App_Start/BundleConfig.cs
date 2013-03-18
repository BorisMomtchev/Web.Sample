using System.Web;
using System.Web.Optimization;

namespace Web.Sample
{
    public partial class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

#if DEBUG
            bundles.IgnoreList.Clear();
#endif
            bundles.Add(new ScriptBundle("~/jquery").Include(
                        "~/Scripts/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));           

            bundles.Add(KendoStyle);
            bundles.Add(KendoScript);

            bundles.Add(BootstrapStyle);
            bundles.Add(BootstrapScript);

            bundles.Add(NotifyStyle);
            bundles.Add(NotifyScript);
        }
    }
}