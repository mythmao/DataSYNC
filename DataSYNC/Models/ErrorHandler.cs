using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataSYNC.Models
{
    public static class ErrorHandler
    {
        public static void ErrorForLog(ExceptionContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string message = filterContext.Exception.Message;
            Logs log = new Logs();
            log.Controller = controller;
            log.Action = action;
            log.InsertDate = DateTime.Now;
            log.Error = message;
            LogsDAL.Insert(log);
        }
    }
}