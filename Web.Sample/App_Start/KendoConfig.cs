using System.Web.Optimization;

namespace Web.Sample
{
    public partial class BundleConfig
    {
        private static Bundle KendoStyle
        {
            get
            {
                return new StyleBundle("~/kendo").Include("~/Content/kendo/2012.3.1114/kendo.common.min.css", "~/Content/kendo/2012.3.1114/kendo.default.min.css");
            }
        }

        private static Bundle KendoScript
        {
            get
            {
                return new ScriptBundle("~/kendo").Include("~/scripts/kendo/2012.3.1114/kendo.web.min.js");
            }
        }
    }
}