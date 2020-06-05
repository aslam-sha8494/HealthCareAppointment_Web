using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class Logactionexecutionfilter : ActionFilterAttribute
    {
        Stopwatch watch;

        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Logactionexecutionfilter));
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            watch = new Stopwatch();
            watch.Start();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            watch.Stop();
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            string strEnablingStatus = ConfigurationManager.AppSettings["EnableLogExecutionFilter"];
            if (strEnablingStatus == "true")
            {
                Trace.WriteLine("ActionExecutionResultLogCapture : " + controllerName + "_" + actionName + "-Elapsed = " + watch.ElapsedMilliseconds + "ms");
                logger.Info("ActionExecutionResultLogCapture : " + controllerName + "_" + actionName + "-Elapsed = " + watch.ElapsedMilliseconds + "ms");
                logger.Debug("ActionExecutionResultLogCapture : " + controllerName + "_" + actionName + "-Elapsed = " + watch.ElapsedMilliseconds + "ms");
            }
        }
    }
}