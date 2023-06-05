using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest.DemoQA.Generic
{
    //[TestClass]
    public class BaseClass
    {
         public IWebDriver driver;
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Console.WriteLine("Assembly initiale");
        }
        [TestInitialize]
        public  void TestInit() 
        {
            driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
        }
        [TestCleanup]
        public void TestCleanup()
        {
            driver.Close();
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("Assembly cleanup");
        }
    }
}
