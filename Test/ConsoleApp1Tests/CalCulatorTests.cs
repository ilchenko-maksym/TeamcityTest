using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class CalCulatorTests
    {

        [TestMethod()]
        public void SquareTest()
        {
            var r = new CalCulator().Add(10, 10);
            Assert.AreEqual(r, 20);
        }
    }
}