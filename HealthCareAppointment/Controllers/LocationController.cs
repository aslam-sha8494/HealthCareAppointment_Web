using HealthCareAppointment.HealthCare_BLL;
using HealthCareAppointment.HealthCare_BLL.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HealthCareAppointment.Controllers
{
    public class LocationController : Controller
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(AccountController));
        private readonly IUnitOfWork _unitOfWork;

        public LocationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Location
        public async Task<ActionResult> Location()
        {
            try
            {
                var locations = new Locations();
                var statelist = await _unitOfWork.States.GetAll();
                locations.StateList = statelist.ToList();
                return View(locations);
            }
            catch (Exception ex)
            {
                logger.Info("Location error : " + ex);
                logger.Debug(ex);
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LocationSave()
        {
            return RedirectToAction("Login");

        }
    }
}