using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SinglePageApplication;
using SinglePageApplication.Controllers;

namespace SinglePageApplication.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PercentOfCPULoadIsReturns()
        {
            HomeController controller = new HomeController();

            float percent;
            float.TryParse(controller.GetPercentOfCPULoad().Data.ToString(), out percent);

            Assert.IsTrue((percent > 0 && percent < 100));
        }

    }
}
