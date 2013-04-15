using System.Collections.Generic;
using System.Web.Mvc;
using Web.Sample.Models;

namespace Web.Sample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPanelItems()
        {
            return Json(PanelItems.ToArray(), JsonRequestBehavior.AllowGet);
        }
    
        private List<PanelItem> PanelItems
        {
            get
            {
                return new List<PanelItem>
                    {
                        new PanelItem {text = "Kendo", imageUrl = Url.Content("~/Content/images/KendoNinja-16px.png"), items = KendoItems},
                        new PanelItem {text = "Bootstrap", imageUrl = Url.Content("~/Content/images/Bootstrap-16px.png"), items = BootstrapItems},
                        new PanelItem {text = "Pine Notifications", imageUrl = Url.Content("~/Content/images/pnotify-16px.png"), items = PNotifyItems},
                        new PanelItem {text = "Dropzone", imageUrl = Url.Content("~/Content/images/Dropzone-16px.png"), items = DropzoneItems}
                    };
            }
        }

        private List<PanelItem> KendoItems
        {
            get
            {
                return new List<PanelItem>
                    {
                        new PanelItem {text = "Grid", url = Url.Action("Grid", "KendoEx")},
                        new PanelItem {text = "ListItem", url = Url.Action("ListItem", "KendoEx")}
                    };
            }
        }

        private List<PanelItem> BootstrapItems
        {
            get
            {
                return new List<PanelItem>
                    {
                        new PanelItem {text = "Buttons", url = Url.Action("Buttons", "BootstrapEx")},
                        new PanelItem {text = "Collapsible", url = Url.Action("Collapsible", "BootstrapEx")},
                        new PanelItem {text = "Theme", url = Url.Action("Index", "BootstrapEx")}
                    };
            }
        }

        private List<PanelItem> PNotifyItems
        {
            get
            {
                return new List<PanelItem>
                    {
                        new PanelItem {text = "Static", url = Url.Action("Static", "PNotifyEx")},
                        new PanelItem {text = "Dynamic", url = Url.Action("Dynamic", "PNotifyEx")}
                    };
            }
        }

        private List<PanelItem> DropzoneItems
        {
            get
            {
                return new List<PanelItem>
                    {
                        new PanelItem {text = "Dropzone", url = Url.Action("Dropzone", "DropzoneEx")}
                    };
            }
        }
    }
}
