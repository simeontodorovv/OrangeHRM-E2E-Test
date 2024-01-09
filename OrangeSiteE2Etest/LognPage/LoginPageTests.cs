using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OrangeSiteE2Etest
{
    [TestFixture, Order(1)]
    public class LoginPageTests : Setup
    {
        [Test, Order(1)]
        [TestCase("Admin", "")]
        [TestCase("", "admin123")]
        public void InValidLoginTest(string username, string password)
        {
            LoginPage page = new LoginPage(driver);
            page.Login(username, password);
            Assert.That(page.errormsg.Text, Is.EqualTo("Required"));
            page.Refresh();
        }

        [Test, Order(2)]
        public void facebookLinkTest()
        {
            LoginPage page = new LoginPage(driver);
            string mainWindow = driver.CurrentWindowHandle;
            for(int i = 0; i < page.links.Count; i++)
            {
                page.links[i].Click();
                string newTabHandle = driver.WindowHandles[^1];
                driver.SwitchTo().Window(newTabHandle);
                Assert.That(mainWindow, Is.Not.EqualTo(newTabHandle));
                driver.SwitchTo().Window(mainWindow);
                
            }
            driver.SwitchTo().Window(mainWindow);
        }

        [Test, Order(3)]    
        [TestCase("Admin", "admin123")]
        public void ValidLoginTest(string username, string password)
        {
            LoginPage page = new LoginPage(driver);
            page.Login(username, password);
            Assert.That(driver.Title, Is.EqualTo("OrangeHRM")); 
            driver.Quit();
        }
    }
}