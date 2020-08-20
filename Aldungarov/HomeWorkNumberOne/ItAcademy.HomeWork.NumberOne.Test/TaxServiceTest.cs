using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ItAcademy.HomeWork.NumberOne.Test
{
    [TestClass]
    public class TaxServiceTest
    {
        #region GetTax with a specific date
        [TestMethod]
        public void When_Minimum_Year_Expect_ZeroPointFifteen()
        {
            var taxSerice = new TaxService(null, null);
            Assert.AreEqual(0.15m, taxSerice.GetTax(DateTime.MinValue));
        }
        
        [TestMethod]
        public void When_Maximum_Year_Expect_ZeroPointFifteen()
        {
            var taxSerice = new TaxService(null, null);
            Assert.AreEqual(0.2m, taxSerice.GetTax(DateTime.MaxValue));
        }

        [TestMethod]
        public void When_Year_Bigger_TwentyNineteen_Expect_ZeroPointTwo()
        {
            var taxSerice = new TaxService(null, null);
            
            //Main test
            DateTime mainDateTest = Convert.ToDateTime("30/03/2020");
            Assert.AreEqual(0.2m, taxSerice.GetTax(mainDateTest));

            //Test for preventing changes
            DateTime dateStart = Convert.ToDateTime("31/12/2019");
            DateTime dateEnd = Convert.ToDateTime("01/01/2020");
            Assert.AreEqual(0.3m, taxSerice.GetTax(dateStart));
            Assert.AreEqual(0.2m, taxSerice.GetTax(dateEnd));
        }

        [TestMethod]
        public void When_Year_Bigger_TwoK_Expect_ZeroPointThree()
        {
            var taxSerice = new TaxService(null, null);

            #region Main test old
            //DateTime mainDateTest = Convert.ToDateTime("05/07/2007");
            //Assert.AreEqual(0.3m, taxSerice.GetTax(mainDateTest));

            ////Test for preventing changes
            //DateTime dateStart = Convert.ToDateTime("31/12/2000");
            //DateTime dateEnd = Convert.ToDateTime("01/01/2020");
            //Assert.AreEqual(0.15m, taxSerice.GetTax(dateStart));
            //Assert.AreEqual(0.2m, taxSerice.GetTax(dateEnd));
            #endregion

            //Main test
            for (DateTime date = Convert.ToDateTime("01/01/2001");
                 date < Convert.ToDateTime("01/01/2020");)
            {
                Assert.AreEqual(0.3m, taxSerice.GetTax(date));
                date = date.AddYears(1);

                //Test for preventing changes
                DateTime dateStart = Convert.ToDateTime("31/12/2000");
                DateTime dateEnd = Convert.ToDateTime("01/01/2020");
                Assert.AreEqual(0.15m, taxSerice.GetTax(dateStart));
                Assert.AreEqual(0.2m, taxSerice.GetTax(dateEnd));
            }
        }

        [TestMethod]
        public void When_Year_Lesser_TwoK_Expect_ZeroPointFifteen()
        {
            var taxSerice = new TaxService(null, null);
            
            //Main test
            DateTime mainDateTest = Convert.ToDateTime("30/05/1991");
            Assert.AreEqual(0.15m, taxSerice.GetTax(mainDateTest));

            //Test for preventing changes
            DateTime dateEnd = Convert.ToDateTime("31/12/2000");
            Assert.AreEqual(0.15m, taxSerice.GetTax(dateEnd));
        }
        #endregion

        #region ApplyTax with a specific date
        [TestMethod]
        public void When_Year_Bigger_TwentyTwenty_Expect_Twelve()
        {
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(""))
                               .Returns(Convert.ToDateTime("16/07/2020"));
            
            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("");
            
            var taxSerice = new TaxService(stubDateTimeService.Object, 
                                           stubUserService.Object);
            
            Assert.AreEqual(12m, taxSerice.ApplyTax(10));
        }

        [TestMethod]
        public void When_Year_Bigger_TwoK_Expected_Thirteen()
        {
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(""))
                               .Returns(Convert.ToDateTime("01/05/2005"));

            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("");

            var taxSerice = new TaxService(stubDateTimeService.Object,
                                           stubUserService.Object);

            Assert.AreEqual(13m, taxSerice.ApplyTax(10));
        }

        [TestMethod]
        public void When_Year_Lesser_TwoK_Expected_ElevenZeroFive()
        {
            var stubDateTimeService = new Mock<IDateTimeService>();
            stubDateTimeService.Setup(x => x.GetCurrentDate(""))
                               .Returns(Convert.ToDateTime("03/03/1991"));

            var stubUserService = new Mock<IUserService>();
            stubUserService.Setup(x => x.GetUiCulture()).Returns("");

            var taxSerice = new TaxService(stubDateTimeService.Object,
                                           stubUserService.Object);

            Assert.AreEqual(11.5m, taxSerice.ApplyTax(10));
        }
        #endregion
    }
}
