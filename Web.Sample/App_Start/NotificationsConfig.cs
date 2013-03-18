using System.Web.Optimization;

namespace Web.Sample
{
    public partial class BundleConfig
    {
        private static Bundle NotifyStyle
        {
            get
            {
                return new StyleBundle("~/notifications").Include("~/Content/jquery.pnotify.css");
            }
        }

        private static Bundle NotifyScript
        {
            get
            {
                return new ScriptBundle("~/notifications").Include("~/Scripts/jquery.pnotify.min.js");
            }
        }
    }
}