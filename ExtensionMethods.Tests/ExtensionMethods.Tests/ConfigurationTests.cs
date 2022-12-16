
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtensionMethods.Library;

namespace ExtensionMethods.Tests
{
    class ConfigurationTests
    {
        [Test]
        public void IsLoaded()
        {
            
            IConfiguration config = null;
            NUnit.Framework.Assert.IsFalse(config.IsLoaded());
        }

        [Test]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, config.Providers.Count());
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(config.IsLoaded());
        }
    }
}
