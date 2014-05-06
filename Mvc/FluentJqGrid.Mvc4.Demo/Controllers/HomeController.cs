using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FluentJqGrid.Mvc4.Demo.Common;

namespace FluentJqGrid.Mvc4.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("JsonLoad", "SimpleLoad");
        }

        public ActionResult About()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult SimpleVerticalMenu()
        {
            var items = MenuItems.GetMenuItems();

            string action = ControllerContext.ParentActionViewContext.RouteData.Values["action"].ToString();
            string controller = ControllerContext.ParentActionViewContext.RouteData.Values["controller"].ToString();

            items.ForEach(i => i.MenuItems.ForEach(m =>
                {
                    if (m.Controller.ToLower().Equals(controller.ToLower()) && m.Action.ToLower().Equals(action.ToLower()))
                    {
                        m.Selected = i.Active = true;
                    }
                }));

            return PartialView(items);
        }
    }
}
