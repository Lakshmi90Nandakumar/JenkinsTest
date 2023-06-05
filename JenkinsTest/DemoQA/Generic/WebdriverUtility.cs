using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest.DemoQA.Generic
{
    public class WebdriverUtility
    {
        public void WebdriverWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
        }
        public void ExplicitElementToBeClick(IWebDriver driver) 
        {
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        }
        public void SelectByText(IWebElement ele,string text)
        {
            SelectElement s = new SelectElement(ele);
            s.SelectByText(text);
        }
        public void SelectByValue(string value, IWebElement ele)
        {
            SelectElement s = new SelectElement(ele);
            s.SelectByValue(value);
        }
        public void SelectByIndex(IWebElement ele, int index)
        {
            SelectElement s = new SelectElement(ele);
            s.SelectByIndex(index);
        }
        public void MoveToEle(IWebElement ele, IWebDriver driver)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(ele);
        }

    }
}
