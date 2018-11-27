﻿using System;
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
            LoginModel model = new LoginModel();
            model.UserId = "abc@xyz.com";
            model.Password = "MVC@123";
            // Act
            ActionResult result = controller.Login(model) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }
    }
}
