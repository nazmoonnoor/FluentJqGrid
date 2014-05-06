using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdventureWorksLT.Data.Data;
using AdventureWorksLT.Data.Infrastructure;
using AdventureWorksLT.Data.Repositories;
using FluentJqGrid.Mvc4.Demo.Infrastructure;

namespace FluentJqGrid.Mvc4.Demo.Controllers
{
    public class CrudController : Controller
    {
        private readonly IProductRepository _productRepository;

        public CrudController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            
            return View();
        }

        //ToDo: Add edit delete feature shoule be added.
        public JsonResult SimpleCrudJsonData(JqGridPost post)
        {
            using (var ctx = new AdventureWorksLTEntities())
            {
                //var customer = ctx.Customer.OrderBy(m => m.CustomerID).Skip(postModel.page * postModel.rows).Take(postModel.rows).ToList();
                var customer = new PagedList<Customer>(ctx.Customer.OrderBy(m => m.CustomerID), post.page, post.rows);
                var jqRows = new List<JqGridRow>();
                foreach (var item in customer)
                {
                    jqRows.Add(new JqGridRow
                    {
                        id = item.CustomerID.ToString(),
                        cell = { item.CustomerID, item.FirstName, item.LastName, item.EmailAddress, item.Phone }
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

            return RedirectToAction("Index");
        }

        public ActionResult OtherInputBoxes()
        {
            using (var ctx = new AdventureWorksLTEntities())
            {
                var category = ctx.ProductCategory.ToList().ToDictionary(item => item.ProductCategoryID.ToString(), item => item.Name);
                ViewBag.ProductCategory = category;
                return View();
            }
        }

        //ToDo: Add edit delete features with different input boxes
        public ActionResult OtherInputBoxesJsonData(JqGridPost post)
        {
            //var productList = _productRepository.Table.ToList();
            using (var ctx = new AdventureWorksLTEntities())
            {
                var product = new PagedList<Product>(
                    ctx.Product.OrderBy(m => m.ProductID), post.page, post.rows);
                
                var jqRows = product.Select(item => new GridRow
                        {
                            Id = item.ProductID.ToString(), 
                            Cell = {item.ProductID, item.Name, item.Size, item.ProductCategory.Name, item.ListPrice}
                        }).ToList();
                var json = product.ToJqGridData(post.page, jqRows);
                return Json(json.ToData(), JsonRequestBehavior.AllowGet);
                //return new XmlResult(json);
            }
        }

        public ActionResult InputJsonData(JqGridPost post)
        {
            using (var ctx = new AdventureWorksLTEntities())
            {
                //var customer = ctx.Customer.OrderBy(m => m.CustomerID).Skip(postModel.page * postModel.rows).Take(postModel.rows).ToList();
                var product = new PagedList<Product>(
                    ctx.Product.OrderBy(m => m.ProductID), post.page, post.rows);
                var jqRows = new List<GridRow>();
                foreach (var item in product)
                {
                    
                    jqRows.Add(new GridRow
                    {
                        Id = item.ProductID.ToString(),
                        Cell = new List<object> { item.ProductID, item.Name, item.Size, item.ProductCategory.Name, item.ListPrice }
                    });
                }
                var json = new GridData
                {
                    Page = post.page,
                    Records = product.TotalCount,
                    Total = product.TotalPages,
                    Rows = jqRows
                };
                //var json = product.ToJqGridData(jqRows);
                return Json(json, JsonRequestBehavior.AllowGet);
                //return new XmlResult(json);
            }
        }
    }
}
