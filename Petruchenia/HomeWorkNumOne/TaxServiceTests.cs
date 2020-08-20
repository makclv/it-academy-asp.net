using System;
using ItAcademy.HomeWork.NumberOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TaxServiceTests
{
    [TestClass]
    public class TaxServiceTests
    {
        
        [TestMethod]
        public void Input_Year_2000_Accert_015m()
        {
            DateTime date = new DateTime(2000, 7, 20);
            var stubUserService = new Mock<IUserService>();
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("ru-Ru");
            stubDateTimeService.Setup(x => x.GetCurrentDate("ru-Ru")).Returns(date);
            var TaxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            Assert.AreEqual(0.15m, TaxService.GetTax(date));            
        }

        [TestMethod]    
        public void Input_Year_2010_Accert_03m()
        {
            DateTime date = new DateTime(2010, 7, 20);
            var stubUserService = new Mock<IUserService>();
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("ru-Ru");
            stubDateTimeService.Setup(x => x.GetCurrentDate("ru-Ru")).Returns(date);
            var TaxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            Assert.AreEqual(0.3m, TaxService.GetTax(date));
        }

        [TestMethod]
        public void Input_Year_2100_Accert_02m()
        {
            DateTime date = new DateTime(2100, 7, 20);
            var stubUserService = new Mock<IUserService>();
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("ru-Ru");
            stubDateTimeService.Setup(x => x.GetCurrentDate("ru-Ru")).Returns(date);
            var TaxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            Assert.AreEqual(0.2m, TaxService.GetTax(date));
        }

        [TestMethod]
        public void Input_Year_2000_In_Fr_Accert_015m()
        {
            DateTime date = new DateTime(2000, 7, 20);
            var stubUserService = new Mock<IUserService>();
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("fr-Fr");
            stubDateTimeService.Setup(x => x.GetCurrentDate("fr-Fr")).Returns(date);
            var TaxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            Assert.AreEqual(0.15m, TaxService.GetTax(date));
        }

        [TestMethod]
        public void Accert_Method_Will_Be_Call_0_Times()
        {
            DateTime date = new DateTime(2100, 7, 20);
            var stubUserService = new Mock<IUserService>();
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("ru-Ru");
            stubDateTimeService.Setup(x => x.GetCurrentDate("ru-Ru")).Returns(date);
            var TaxService = new TaxService(stubDateTimeService.Object, stubUserService.Object);
            stubDateTimeService.Verify(x => x.GetCurrentDate("ru-Ru"), Times.Never);
        }
    }
}
