using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestTaxService
{
    [TestClass]
    public class TestTaxService
    {
        [TestMethod]
        public void TestApplyTax()
        {
            var userService = Mock.Of<IUserService>(
                x => x.GetUiCulture() == It.IsAny<string>());

            var dateTimeService = Mock.Of<IDateTimeService>(
                x => x.GetCurrentDate(It.IsAny<string>()) == It.IsAny<DateTime>());

            var taxservice = new TaxService(dateTimeService, userService);

            Assert.AreEqual(taxservice.ApplyTax(0), 0);
        }

        [TestMethod]
        public void TestGetTax()
        {
           
            var userService = Mock.Of<IUserService>(
                x => x.GetUiCulture() == It.IsAny<string>());

            var dateTimeService = Mock.Of<IDateTimeService>(
                x => x.GetCurrentDate(It.IsAny<string>()) == It.IsAny<DateTime>());

            var taxservice = new TaxService(dateTimeService, userService);

            Assert.AreEqual(taxservice.GetTax(new DateTime(2020, 1, 1)), 0.2m);
            Assert.AreEqual(taxservice.GetTax(new DateTime(2019, 1, 1)), 0.3m);
            Assert.AreEqual(taxservice.GetTax(new DateTime(2001, 1, 1)), 0.3m);
            Assert.AreEqual(taxservice.GetTax(new DateTime(1999, 1, 1)), 0.15m);
        }
    }
}



