using System.Web.Optimization;

namespace Web.Sample
{
    public partial class BundleConfig
    {
        private static Bundle BootstrapStyle
        {
            get
            {
                return new StyleBundle("~/bootstrap").Include("~/Content/bootstrap.min.css", "~/Content/bootstrap-responsive.min.css");
            }
        }

        private static Bundle BootstrapScript
        {
            get
            {
                return new ScriptBundle("~/bootstrap").Include("~/Scripts/bootstrap.min.js", "~/Scripts/bootstrap-responsive.min.js");
            }
        }
         
    }
}