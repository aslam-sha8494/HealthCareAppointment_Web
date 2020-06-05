using HealthCareAppointment.HealthCare_BLL;
using HealthCareAppointment.HealthCare_BLL.AccountModels;
using HealthCareAppointment.HealthCare_DAL;
using HealthCareAppointment.HealthCare_BLL.Repositories;
using HealthCareAppointment.HealthCare_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using HealthCareAppointment.Controllers;
using System.Web.Mvc;

namespace HealthcareAppointment.UnitTest.MvcControllers
{
    [TestClass]
    public class AccountControllerUnitTest
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        private readonly Mock<IRegisterRepository> _mockRegisterRepository = new Mock<IRegisterRepository>();
        private readonly Mock<IRoleRepository> _mockRoleRepository = new Mock<IRoleRepository>();
        private AccountController _accountcontroller;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork.UserRegisters = _mockRegisterRepository.Object;
            _unitOfWork.UserRoles = _mockRoleRepository.Object;
            _accountcontroller = new AccountController(_unitOfWork);
        }

        [TestMethod]
        public void Register_Test()
        {
            // Arrange
            IList<UserRoles> rolelist = null;
            _mockRoleRepository.Setup(x => x.GetRoles())
                    .Returns(rolelist = new List<UserRoles> { new UserRoles {RoleId = 1 , RoleName = "Admin" }, new UserRoles { RoleId = 2, RoleName = "Doctor" }, new UserRoles { RoleId = 3, RoleName = "Patient" } });
            
            // Act
            var roleresult = _accountcontroller.Register();

            //Assert
            Assert.IsInstanceOfType(roleresult, typeof(ActionResult));
            Assert.IsInstanceOfType(roleresult.Model, typeof(UserRegisters));
            Assert.AreEqual(rolelist.Count, ((UserRegisters)roleresult.Model).RoleList.Count);
        }

    }
}
