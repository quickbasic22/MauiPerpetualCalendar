using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiPerpetualCalendar.Models;

namespace MauiPerpetualCalendar.Tests
{
    [TestClass()]
    public class PerpetualCalendarTests
    {
        [TestMethod()]
        public bool PerpetualCalendarTest()
        {
            PerpetualCalendar calendar = new PerpetualCalendar();
            var yes = calendar.Year1.Count > 0;
            Assert.IsTrue(yes);
            return yes;
        }
    }
}