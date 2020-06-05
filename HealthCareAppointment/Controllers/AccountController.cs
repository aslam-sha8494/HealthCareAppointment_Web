using HealthCareAppointment.HealthCare_BLL;
using HealthCareAppointment.HealthCare_BLL.AccountModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HealthCareAppointment.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        #region Initialization

        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(AccountController));

        private readonly IUnitOfWork _unitOfWork;

        public AccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Register

        public ViewResult Register()
        {
            try
            {
                var userregister = new UserRegisters();
                var roleresult = _unitOfWork.UserRoles.GetRoles();
                userregister.RoleList = roleresult.ToList();
                return View(userregister);
            }
            catch (Exception ex)
            {
                logger.Info("Register error : " + ex);
                logger.Debug(ex);
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterSave(UserRegisters registerObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _unitOfWork.UserRegisters.Add(new UserRegisters()
                    {
                        UserName = registerObj.UserName,
                        FullName = registerObj.FullName,
                        Password = registerObj.Password,
                        ConfirmPassword = registerObj.ConfirmPassword,
                        PhoneNumber = registerObj.PhoneNumber,
                        RoleId = registerObj.RoleId
                    });
                    _unitOfWork.Complete();
                    TempData["RegisterResultMessage"] = "Registered successfully. Kindly Login";
                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                logger.Info("Register error : " + ex);
                logger.Debug(ex);
                return View("Error");
            }

        }

        #endregion

        #region Login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ValidateLoginUsers(UserRegisters UserLoginDetails)
        {
            try
            {
                var loginuser = await _unitOfWork.UserRegisters.ValidateLoginUsers(UserLoginDetails);
                if (loginuser != null)
                {
                    Session["Username"] = loginuser.FullName;
                    Session["UserId"] = loginuser.RegisterId;
                    if (loginuser.RoleId == 1)
                        Session["Role"] = "Admin";
                    else if (loginuser.RoleId == 2)
                        Session["Role"] = "Doctor";
                    else
                        Session["Role"] = "Patient";
                    return Redirect("/Home/Dashboard");
                }
                return View(UserLoginDetails);
            }
            catch (Exception ex)
            {
                logger.Info("Login error : " + ex);
                logger.Debug(ex);
                return View("Error");
            }
        }

        #endregion


    }
}