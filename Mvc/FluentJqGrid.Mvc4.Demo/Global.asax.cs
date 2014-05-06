using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FluentJqGrid.Mvc4.Demo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.SetControllerFactory(new Infrastructure.Elmah.ErrorHandlingControllerFactory());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Don't rewrite requests for content (.png, .css) or scripts (.js)
            if (Request.Url.AbsolutePath.Contains("/Content/") ||
                Request.Url.AbsolutePath.Contains("/Scripts/"))
                return;

            // If uppercase chars exist, redirect to a lowercase version
            var url = Request.Url.ToString();
            if (System.Text.RegularExpressions.Regex.IsMatch(url, @"[A-Z]"))
            {
                Response.Clear();
                Response.Status = "301 Moved Permanently";
                Response.StatusCode = (int)System.Net.HttpStatusCode.MovedPermanently;
                Response.AddHeader("Location", url.ToLower());
                Response.End();
            }
        }
    }
}