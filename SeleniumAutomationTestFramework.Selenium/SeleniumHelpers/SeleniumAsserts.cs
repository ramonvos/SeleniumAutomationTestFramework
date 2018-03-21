using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Selenium.SeleniumHelpers
{
    public static class SeleniumAsserts
    {   
        public static void assertValueAtElement(this IWebElement element, String value)
        {
            try
            {
                Assert.AreEqual(element, value);
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        public static void assertTextAtElement(this IWebElement element, String text)
        {
            try
            {
                Assert.AreEqual(element.Text, text);
            }
            catch (Exception)
            {

                throw;
            }


        }
        public static void assertContainsTextAtElement(this IWebElement element, String text)
        {
            try
            {
                Assert.IsTrue(element.Text.Contains(text));
            }
            catch (Exception)
            {

                throw;
            }


        }
        public static void assertTextAreEqual(String textExpected, String textActual)
        {
            try
            {
                Assert.AreEqual(textExpected, textActual);
            }
            catch (Exception)
            {

                throw;
            }


        }
        public static void assertElementNotPresent(this IWebElement element)
        {
            try
            {
                Assert.IsFalse(element.Displayed);
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
