using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Selenium.SeleniumHelpers
{
    public static class SeleniumSetMethods
    {   
        public static void clickToElement(this IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void sendKeysToElement(this IWebElement element, string value)
        {
            try
            {
                element.SendKeys(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
