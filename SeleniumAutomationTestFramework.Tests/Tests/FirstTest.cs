using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutomationTestFramework.Selenium.SeleniumHelpers;
using SeleniumAutomationTestFramework.Tests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Tests.Tests
{
    [TestFixture]
    public class FirstTest : TestBase
    {

        [Test]
        public void TestNameNull()
        {
            IWebElement element = null;
            element.clickToElement();

        }
    }
}
