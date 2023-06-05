using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest.DemoQA.POM
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//div//h5[contains(.,'Elements')]")]
        IWebElement elementClick;

        [FindsBy(How = How.XPath, Using = "//div//h5[contains(.,'Forms')]")]
        private IWebElement formsClick { get;set; }

        [FindsBy(How=How.XPath,Using = "//h5[contains(.,'Alerts, Frame & Windows')]")]
        private IWebElement alertClick { get;set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(.,'Widgets')]")]
        private IWebElement widgetsClick { get;set; }

        public HomePage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        public void ElementClick()
        {
            elementClick.Click();
        }
        public void FormsClick()
        {
            formsClick.Click();
        }
        public void AlertClick() 
        {
            alertClick.Click();
        }
        
    }
}
