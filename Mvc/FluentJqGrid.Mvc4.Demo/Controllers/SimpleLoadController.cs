using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdventureWorksLT.Data.Data;
using AdventureWorksLT.Data.Infrastructure;
using FluentJqGrid.Mvc4.Demo.Common;
using FluentJqGrid.Mvc4.Demo.Infrastructure;
using FluentJqGrid.Mvc4.Demo.SampleSources;
using FluentJqGrid.Settings;

namespace FluentJqGrid.Mvc4.Demo.Controllers
{
    public class SimpleLoadController : Controller
    {
        private readonly SrcSamples _srcSamples;
        private readonly IRepository<Product> _productRepository;

        public SimpleLoadController(SrcSamples srcSamples, IRepository<Product> productRepository)
        {
            _srcSamples = srcSamples;
            _productRepository = productRepository;
        }

        public ActionResult JsonLoad()
        {
            ViewData["src"] = _srcSamples.SetSamples(SimpleLoad.JsonLoad_View, SimpleLoad.JsonLoad_Controller,
                                                     SimpleLoad.JsonLoad_Description);
            return View();
        }

        public ActionResult JsonLoadAjaxPost(JqGridPost post)
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

        public ActionResult StronglyTypedColumns()
        {
            ViewData["src"] = _srcSamples.SetSamples(SimpleLoad.StronglyTypedColumns_View, SimpleLoad.StronglyTypedColumns_Controller,
                                                     SimpleLoad.StronglyTypedColumns_Description);

            return View(new Models.ProductModel());
        }

        public ActionResult StronglyTypedColumnsAjaxPost(JqGridPost post)
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

        public ActionResult XmlLoad()
        {
            ViewData["src"] = _srcSamples.SetSamples(SimpleLoad.XmlLoad_View, SimpleLoad.XmlLoad_Controller,
                                                     SimpleLoad.XmlLoad_Description);
            return View();
        }

        public ActionResult XmlLoadAjaxPost(JqGridPost post)
        {
            var products = new PagedList<Product>(
                    _productRepository.Table.OrderBy(m => m.ProductID), post.page, post.rows);

            var jqRows = products.Select(item => new GridRow
            {
                Id = item.ProductID.ToString(),
                Cell = { item.ProductID, item.Name, item.Size, item.ProductCategory.Name, item.ListPrice }
            }).ToList();
            var json = products.ToJqGridData(post.page, jqRows);
            return Content(json.ToData().ToXml(), "text/xml");
        }

        public ActionResult ColumnSettingLoad()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);
            var columns = new[]
                {
                    new JqGridColumnSettings
                    {
                        Name = "ProductID",
                        Header ="Id"
                    },
                    new JqGridColumnSettings
                    {
                        Name = "Name",
                        Header ="Name",
                        EditSettings = new EditSettings
                            {
                                EditType = EditType.TextArea,
                                Cols = 10,
                                Rows = 2
                            },
                        Align = ColumnAlign.Right
                    },
                    new JqGridColumnSettings
                    {
                        Name = "Size",
                        Header ="Size"
                    },
                };
            ViewData["ProductColumns"] = columns;
            return View();
        }

        public ActionResult ColumnSettingLoadAjaxPost(JqGridPost post)
        {
            var products = new PagedList<Product>(
                    _productRepository.Table.OrderBy(m => m.ProductID), post.page, post.rows);

            var jqRows = products.Select(item => new GridRow
            {
                Id = item.ProductID.ToString(),
                Cell = { item.ProductID, item.Name, item.Size} //, item.ProductCategory.Name, item.ListPrice }
            }).ToList();
            var json = products.ToJqGridData(post.page, jqRows);
            return Json(json.ToData(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult LoadOnce()
        {
            ViewData["src"] = _srcSamples.SetSamples(string.Empty, string.Empty,
                                                     string.Empty);
            return View(new Models.ProductModel());
        }

        public ActionResult LoadOnceAjaxPost(JqGridPost post)
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
    }
}
