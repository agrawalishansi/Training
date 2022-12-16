using NUnit.Framework;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExtensionMethods.Tests
{
    public class EnumerableTests
    {
        IEnumerable<string> _strings;

        [SetUp]
        public void Setup()
        {
            _strings = new List<string> { "a", "b", "c" };
        }

        [Test]
        public void Count()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, _strings.Count());

            var list = new StringList();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, list.Count());
        }
    }
}