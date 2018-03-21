using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumAutomationTestFramework.Selenium.SeleniumHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.ExtentReport
{
    public class Logger
    {
        protected ExtentReports _extent;
        protected ExtentTest _test;

        
        public void ExtentSetup()
        {
            if (_extent == null)
            {
                var dir = SeleniumGetMethods.getTestDirectory() + "\\";
                //var fileName = this.GetType().ToString() +  ".html";
                var fileName =  "Reporter.html";
                var htmlReporter = new ExtentHtmlReporter(dir + fileName);

                _extent = new ExtentReports();
                _extent.AttachReporter(htmlReporter);
            }
            
        }

        public void ExtentClose()
        {
            _extent.Flush();
        }
              
        public void ExtentBefore()
        {
            _test = _extent.CreateTest(SeleniumGetMethods.getTestName()).AssignCategory(SeleniumGetMethods.getClassName()).AssignAuthor();
            
        }

        public void ExtentExceptions()
        {
            Exception e = new Exception();
            
            _test.Fail(e.Message);


        }

        public void ExtentLogPass(String m)
        {
            _test.Pass(m);
            // or
            _test.Log(Status.Pass, m);
        }

        public void ExtentAfter()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
        }
    }
}
