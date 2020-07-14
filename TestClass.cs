// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.spotify.com/co/account/overview/");
            driver.Manage().Window.Maximize();
            IWebElement user = driver.FindElement(By.Id("login-username"));
            user.SendKeys("This one is executed by jenkins  4");
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\Images\Test03.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }
    }
}
