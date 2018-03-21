using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Selenium.SeleniumHelpers
{
    public static class SeleniumGetMethods
    {      
        
        public static String getTestName()
        {
            String testName = null;
            try
            {
                testName = TestContext.CurrentContext.Test.Name;
                return testName;
                
            }
            catch (Exception)
            {

                return null;
                
            }

        }
        public static String getClassName()
        {
            String className = null;
            try
            {
                className = TestContext.CurrentContext.Test.ClassName;
                return className;

            }
            catch (Exception)
            {

                return null;

            }

        }

        public static String getTestDirectory()
        {
            String directory = null;
            try
            {
                directory = TestContext.CurrentContext.TestDirectory;
                return directory;

            }
            catch (Exception)
            {

                return null;

            }

            
        }

    }
}
