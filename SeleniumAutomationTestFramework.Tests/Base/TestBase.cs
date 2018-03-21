using NUnit.Framework;
using SeleniumAutomationTestFramework.DriverSetup;
using SeleniumAutomationTestFramework.ExtentReport;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Tests.Base
{
    [SetUpFixture]
    public abstract class TestBase
    {

        Logger report = new Logger();
        [OneTimeSetUp]
        protected void Setup()
        {
            report.ExtentSetup();

            DriverFactory.Initialize("IEDriver");


        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            report.ExtentAfter();
        }
            

        [SetUp]
        public void BeforeTest()
        {
            report.ExtentBefore();
        }

        [TearDown]
        public void AfterTest()
        {
            //report.ExtentAfter();
        }
    }

    
}
