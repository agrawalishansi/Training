using ExtensionMethods.Contracts;
using NUnit.Framework;
using System;

namespace ExtensionMethods.Tests.Contracts
{
    public class DateExtensionsTests
    {
        [Test]
        public void ToUnixSeconds()
        {
            var dateTime = new DateTime(2019, 09, 03, 12, 03, 02);
            var timestamp = dateTime.ToUnixSeconds();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1567508582L, timestamp);
        }
        [Test]
        public void FormatLegacyDateC0()
        {
            var dateTime = new DateTime(1921, 04, 25);
            var formatted = dateTime.Format();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("0210425", formatted);
        }

        [Test]
        public void FormatLegacyDateC1()
        {
            var dateTime = new DateTime(1932, 12, 31);
            var formatted = dateTime.Format();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1321231", formatted);
        }
    }
}