using DataSYNC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace System.Web.Mvc
{
    public class ErrorFilterAttribute:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //base.OnException(filterContext);
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string message = filterContext.Exception.Message;
            Logs log = new Logs();
            log.Controller = controller;
            log.Action = action;
            log.InsertDate = DateTime.Now;
            log.Error = message;

            LogsDAL.Insert(log);
            HttpContext.Current.Response.Write(message);
        }
    }
}