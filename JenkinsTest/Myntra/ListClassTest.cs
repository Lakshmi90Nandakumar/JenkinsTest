using JenkinsTest.DemoQA.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest.Myntra
{
    [TestClass]
    public class ListClassTest
    {
        [TestMethod]
        public void test()
        {
            WebdriverUtility wdu = new WebdriverUtility();
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.myntra.com";
            wdu.WebdriverWait(driver);
            IWebElement hL=driver.FindElement(By.XPath("//div//a[text()='Home & Living']"));
            Actions a = new Actions(driver);
            a.MoveToElement(hL).Perform();
            IReadOnlyCollection<IWebElement> alloption=driver.FindElements(By.XPath("//li/a[text()='Home Décor']/parent::li/following-sibling::li/a[@class='desktop-categoryLink']"));
            foreach (IWebElement el in alloption)
            {
                Console.WriteLine(el.Text);
            }
            driver.Close();
        }
        [TestMethod]
        public void test2() 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            IWebDriver driver = new ChromeDriver(options);
            WebdriverUtility wdu = new WebdriverUtility();
            driver.Url = "https://www.myntra.com";
            wdu.WebdriverWait(driver);
            driver.Manage().Window.Maximize();
            IWebElement hL = driver.FindElement(By.XPath("//div[@class='desktop-navLink']//a[text()='Men']"));
            Actions a = new Actions(driver);
            a.MoveToElement(hL).Perform();
            IWebElement jac=driver.FindElement(By.XPath("//li[@data-reactid=\"40\"]//a[text()='Jackets']"));
            a.MoveToElement(jac).Click().Perform();
            for(; ;)
            {
                try
                {
                    driver.FindElement(By.XPath("//li[@class='results-liDummy'][1]"));
                    break;
                }
                catch(Exception e) 
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("window.scrollBy(0,3000)");
                }


            }
            IReadOnlyCollection<IWebElement> allImg = driver.FindElements(By.XPath("//img"));
            Console.WriteLine(allImg.Count);
            driver.Close();
        }
        [TestMethod]
        public void test3()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            IWebDriver driver = new ChromeDriver(options);
            WebdriverUtility wdu = new WebdriverUtility();
            driver.Url = "https://www.myntra.com";
            wdu.WebdriverWait(driver);
            driver.Manage().Window.Maximize();
            IWebElement hL = driver.FindElement(By.XPath("//div[@class='desktop-navLink']//a[text()='Men']"));
            Actions a = new Actions(driver);
            a.MoveToElement(hL).Perform();
            IWebElement jac = driver.FindElement(By.XPath("//li[@data-reactid=\"40\"]//a[text()='Jackets']"));
            a.MoveToElement(jac).Click().Perform();
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            javaScript.ExecuteScript("window.scrollTo(0,0)");
            driver.FindElement(By.XPath("//span[@class='myntraweb-sprite sort-downArrow sprites-downArrow']")).Click();
            driver.FindElement(By.XPath("//li[.='Customer Rating']")).Click();
            Thread.Sleep(2000);
            string txt=driver.FindElement(By.XPath("//h3[.='MANGO MAN']")).Text;
            Assert.AreEqual("MANGO MAN", txt);
            Console.WriteLine("MangoMan is displayed");

            IReadOnlyCollection<IWebElement> allItem=driver.FindElements(By.XPath("//ul[@class='results-base']/li"));
            allItem.ElementAt(5).Click();
        }
        [TestMethod]
        public void ReplaceUS()
        {
            string s = "lakshmi_chitra_it";
            char[] ch=s.ToCharArray();
            for(int i=0; i<ch.Length;i++)
            {
                if (ch[i]=='_')
                {
                    ch[i] = ' ';
                }
            }
            for(int i=0;i<ch.Length;i++)
            {
                Console.Write(ch[i]);
            }
        }
    }
}
