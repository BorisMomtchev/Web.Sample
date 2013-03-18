using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                        new PanelItem {text = "Kendo Examples", imageUrl = Url.Content("~/Content/images/KendoNinja-16px.png"), items = KendoItems},
                        new PanelItem {text = "Bootstrap Examples", imageUrl = Url.Content("~/Content/images/Bootstrap-16px.png")}
                    };
            }
        }

        private List<PanelItem> KendoItems
        {
            get
            {
                return new List<PanelItem>
                    {
                        new PanelItem {text = "Grid", url = Url.Action("Index", "KendoEx", null, "http")},
                        new PanelItem {text = "ListItems", url = Url.Action("Index", "KendoEx")}
                    };
            }
        } 
    }
}
