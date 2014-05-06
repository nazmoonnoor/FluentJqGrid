using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorksLT.Data.Data;
using AdventureWorksLT.Data.Infrastructure;
using FluentJqGrid.Mvc4.Demo.Common;
using FluentJqGrid.Mvc4.Demo.Infrastructure;

namespace FluentJqGrid.Mvc4.Demo.Controllers
{
    public class SearchingController : Controller
    {
        private readonly SrcSamples _srcSamples;
        private readonly IRepository<Product> _productRepository;

        public SearchingController(SrcSamples srcSamples, IRepository<Product> productRepository)
        {
            _srcSamples = srcSamples;
            _productRepository = productRepository;
        }

        public ActionResult ToolbarSearching()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);

            return View(new Models.ProductModel());
        }

        public JsonResult ToolbarSearchingAjaxPost(JqGridPost post)
        {
            var products = _productRepository.Table.OrderBy(m => m.ProductID);

            var jqRows = products.ToList().Select(item => new GridRow
            {
                Id = item.ProductID.ToString(),
                Cell = { item.ProductID, item.Name, item.Size, item.ProductCategory.Name, item.ListPrice }
            }).ToList();
            var json = products.ToJqGridData(post.page, post.rows, jqRows);
            return Json(json.ToData(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult CustomSearching()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);

            return View(new Models.ProductModel());
        }

        public JsonResult CustomSearchingAjaxPost(JqGridPost post)
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

        public ActionResult SingleColumnSearching()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);

            return View(new Models.ProductModel());
        }

        public JsonResult SingleColumnSearchingAjaxPost(JqGridPost post)
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

        public ActionResult AdvancedSearching()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);

            return View(new Models.ProductModel());
        }

        public JsonResult AdvancedSearchingAjaxPost(JqGridPost post)
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
    }
}
