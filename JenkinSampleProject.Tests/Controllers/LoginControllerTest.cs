using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinSampleProject;
using JenkinSampleProject.Controllers;
using JenkinSampleProject.Models;
using NUnit.Framework;

namespace JenkinSampleProject.Tests.Controllers
{
    [TestFixture]
    public class LoginControllerTest
    {
        [Test]
        public void LoginTest_Given_Credentials_NavigatesTo_HomePage()
        {
            // Arrange
            LoginController controller = new LoginController();
            LogOn model = new LogOn();
            model.UserId = "jenkins@tl.com";
            model.Password = "jenkins";
            // Act
            ActionResult result = controller.Login(model) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }
    }
}
