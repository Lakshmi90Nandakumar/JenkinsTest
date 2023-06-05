using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://leafground.com/window.xhtml");
            IWebElement ele=driver.FindElement(By.XPath("//span[text()='Open Multiple']"));
            ele.Click();
            driver.Close();

        }
    }
}