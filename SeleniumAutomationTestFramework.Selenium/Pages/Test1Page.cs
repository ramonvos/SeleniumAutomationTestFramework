using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumAutomationTestFramework.Selenium.SeleniumHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationTestFramework.Selenium.Pages
{
    public class Test1Page
    {
        private IWebDriver _Instance;
        public Test1Page()
        {
            PageFactory.InitElements(this._Instance,15);
        }

        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement txtNome;

        [FindsBy(How = How.Id, Using = "name")]
        private List<IWebElement> names;


        public void preencherCampoNome(String nome)
        {
            txtNome.sendKeysToElement(nome);
        }
    }
}
