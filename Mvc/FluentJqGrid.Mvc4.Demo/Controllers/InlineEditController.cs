using System.Linq;
using System.Web.Mvc;
using AdventureWorksLT.Data.Data;
using AdventureWorksLT.Data.Infrastructure;
using FluentJqGrid.Mvc4.Demo.Common;
using FluentJqGrid.Mvc4.Demo.Infrastructure;

namespace FluentJqGrid.Mvc4.Demo.Controllers
{
    public class InlineEditController : Controller
    {
        private readonly SrcSamples _srcSamples;
        private readonly IRepository<Product> _productRepository;

        public InlineEditController(SrcSamples srcSamples, IRepository<Product> productRepository)
        {
            _srcSamples = srcSamples;
            _productRepository = productRepository;
        }

        public ActionResult UsingCustomButtons()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);

            return View(new Models.ProductModel());
        }

        public JsonResult UsingCustomButtonsAjaxPost(JqGridPost post)
        {
            var products = new PagedList<Product>(
                    _productRepository.Table.OrderBy(m => m.ProductID), post.page, post.rows);

            var jqRows = products.Select(item => new GridRow
            {
                Id = item.ProductID.ToString(),
                Cell = { item.ProductID, item.Name, item.Size, item.ProductCategory.Name, item.ListPrice }
            }).ToList();
            var json = products.ToJqGridData(post.page, jqRows);
            return Json(json.ToData(), JsonRequestBehavior.AllowGet);
        }

        public string UsingCustomButtonsEdited()
        {
            return "1";
        }

        public ActionResult UsingNavigators()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                    string.Empty);
            return View();
        }

        public JsonResult UsingNavigatorsAjaxPost(JqGridPost post)
        {
            var product = new PagedList<Product>(
                    _productRepository.Table.OrderBy(m => m.ProductID), post.page, post.rows);

            var jqRows = product.Select(item => new GridRow
            {
                Id = item.ProductID.ToString(),
                Cell = { item.ProductID, item.Name, item.Size, item.ProductCategory.Name, item.ListPrice }
            }).ToList();
            var json = product.ToJqGridData(post.page, jqRows);
            return Json(json.ToData(), JsonRequestBehavior.AllowGet);
        }

        public string UsingNavigatorsEdited(FormCollection collection)
        {
            
            return "1";
        }
    }
}
