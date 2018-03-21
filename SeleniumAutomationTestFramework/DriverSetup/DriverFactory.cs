using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.DriverSetup
{
    public class DriverFactory
    {
       public static IWebDriver Instance { get; set; }
        
        public static string PATH_TO_IEDRIVER64 = @"D:\Selenium\IEDriverServerx64\";
        public static string  URL = "https://www.gmail.com/";
        public static void Initialize(string browser)
        {
            switch (browser)
            {
                case "IEDriver":
                
                var IEOptions = new InternetExplorerOptions();
                    using (Instance)
                    {
                        IEOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    }

                    Instance = new InternetExplorerDriver(PATH_TO_IEDRIVER64, IEOptions);
                    break;

                case "Chrome":
                    // Create the driver.
                    var ChromeOptions = new ChromeOptions();

                    using (Instance)
                    {
                        ChromeOptions.AddArgument("--start-maximized");
                    }
                    
                    Instance = new ChromeDriver(System.AppDomain.CurrentDomain.BaseDirectory, ChromeOptions);
                    break;

                default:
                    break;
            }
            
            

            



        }
    }
}
