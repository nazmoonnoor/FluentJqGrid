using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdventureWorksLT.Data.Data;
using AdventureWorksLT.Data.Infrastructure;

namespace FluentJqGrid.Mvc4.Demo.Controllers
{
    public class LoadingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestPage()
        {
            return View();
        }

        public JsonResult JsonLoading(JqGridPost post)
        {
            using (var ctx = new AdventureWorksLTEntities())
            {
                //var customer = ctx.Customer.OrderBy(m => m.CustomerID).Skip(postModel.page * postModel.rows).Take(postModel.rows).ToList();
                var customer = new PagedList<Customer>(ctx.Customer.OrderBy(m=>m.CustomerID), post.page, post.rows);
                var jqRows = new List<JqGridRow>();
                foreach (var item in customer)
                {
                    jqRows.Add(new JqGridRow
                    {
                        id = item.CustomerID.ToString(),
                        cell = { item.CustomerID, item.FirstName, item.LastName, item.EmailAddress,item.Phone }
                    });
                }
                var json = new JqGridData
                {
                    page = post.page,
                    records = customer.TotalCount,
                    total = customer.TotalPages,
                    rows = jqRows
                };

                return Json(json, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult JsonSaving(FormCollection collection)
        {

            return RedirectToAction("TestPage");
        }
    }
}
