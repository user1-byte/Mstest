using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mstest
{
    [TestClass]
    public class UnitTest1
    {
    //     IWebDriver driver;
    //     [TestMethod]
    //     public void OpenNavMethod()
    //     {
    
        
 
	// //Local Selenium WebDriver
    //     driver = new ChromeDriver(@"D:\C Sharp\Mstest");
    //     driver = new ChromeDriver();
    //     driver.Navigate().GoToUrl("https://www.amazon.com/");
    //     }

    //     [TestMethod]
    //     public void MaxCloseMethod()
    //     {
    //     driver.Manage().Window.Maximize();
    //     System.Threading.Thread.Sleep(2000);
    //     driver.Close();
    //     }


       [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
 
	// Local Selenium WebDriver
    driver = new ChromeDriver(@"D:\C Sharp\Mstest");
    //driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://www.amazon.com/");
    //Console.Writeline("hello");
    driver.Manage().Window.Maximize();
    System.Threading.Thread.Sleep(2000);
    driver.Quit();
        }
    }
}
