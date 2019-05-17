using Microsoft.VisualStudio.TestTools.UnitTesting;
using testingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingDemo.Tests
{
    [TestClass()]
    public class SampleTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Sample s = new Sample();
            int res = s.Add(10, 20);
            Assert.AreEqual(30, res);
        }
    }
}