using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthCareAppointment.HealthCare_BLL.Models;

namespace HealthCareAppointment.Controllers
{
    public class HomeController : Controller
    {

        #region Initializemethods

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        #endregion

        #region Logout

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return Redirect("/Account/Login");
        }

        #endregion
    }
}
