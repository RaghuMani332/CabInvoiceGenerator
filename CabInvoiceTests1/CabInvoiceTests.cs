using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CabInvoiceTests
    {
        [TestMethod()]
        public void TotalFareTest()
        {
            double distance = 5;
            int Time = 2;
            int Expectred = 70;
            double Actual = (CabInvoice.TotalFare(5,2));
            Assert.AreEqual(Expectred,Actual);

        }
    }
}