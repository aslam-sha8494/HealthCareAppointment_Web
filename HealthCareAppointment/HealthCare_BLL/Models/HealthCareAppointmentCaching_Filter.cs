﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http.Filters;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class HealthCareAppointmentCaching_Filter : ActionFilterAttribute
    {
        public int TimeDuration { get; set; }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(TimeDuration),
                MustRevalidate = true,
                Public = true
            };
        }
    }
}