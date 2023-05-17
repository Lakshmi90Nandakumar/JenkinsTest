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
            driver.Navigate().GoToUrl("http://localhost:8084");

            driver.Close();

        }
    }
}