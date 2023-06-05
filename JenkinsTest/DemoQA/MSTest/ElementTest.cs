using JenkinsTest.DemoQA.Generic;
using JenkinsTest.DemoQA.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest.DemoQA.MSTest
{
    [TestClass]
    public class ElementTest:BaseClass
    {
        [TestMethod]
        public void ElentTest()
        {
            /*HomePage hp = new HomePage(driver);
            hp.ElementClick();
            IReadOnlyCollection<IWebElement> frame=driver.FindElements(OpenQA.Selenium.By.TagName("iframe"));
            foreach(IWebElement ele in frame)
            {
                Console.WriteLine(ele);
                driver.SwitchTo().Frame(ele);
                HomePage.elementClick().Click();
               // Console.WriteLine(ele.Text);

            }
           // frame(0).cl
        */
        }
    }
}
