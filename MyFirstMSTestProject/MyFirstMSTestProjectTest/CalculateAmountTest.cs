using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstMSTestProjectTest
{
    [TestClass]
    public class CalculateAmountTest
    {
        [TestMethod]
        public void CalculateAmountAfterDiscountTest()
        {
            Decimal TestTotalAmount = 10;
            Decimal TestDiscountAmount = 5;
            String ActualFinalAmount = "5";

            String TestFinalAmount = (TestTotalAmount - TestDiscountAmount).ToString();

             Assert.AreEqual(ActualFinalAmount, TestFinalAmount);



        }
    }
}
