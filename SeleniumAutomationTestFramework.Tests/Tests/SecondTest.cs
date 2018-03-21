using NUnit.Framework;
using SeleniumAutomationTestFramework.DriverSetup;
using SeleniumAutomationTestFramework.ExtentReport;
using SeleniumAutomationTestFramework.Tests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Tests.Tests
{
    [TestFixture]
    public class SecondTest : TestBase
    {
        [Test]
        public void TestNameNull2()
        {
            DriverFactory.Instance.Navigate().GoToUrl(DriverFactory.URL);

            
                Logger log = new Logger();
                
                log.ExtentExceptions();


            
        }
    }   
}
