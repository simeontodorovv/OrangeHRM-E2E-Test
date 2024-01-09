using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OrangeSiteE2Etest
{
    [TestFixture, Order(2)]
    public class DashboardTests : Setup
    {
        [Test, Order(1)]
        public void quickAccessTest()
        {
            Dashboard dashboard = new Dashboard(driver);
            dashboard.GoToDashboard();    
            for (int i = 0; i < dashboard.quickLaunch.Count; i++)
            {
                dashboard.quickLaunch[i].Click();
                Assert.That(driver.Url, Is.Not.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
                driver.Navigate().Back();
            }
        }

        [Test, Order(2)]
        public void myActions()
        {
            Dashboard dashboard = new Dashboard(driver);
            foreach (IWebElement action in dashboard.myActions)
            {
                action.Click();
                Assert.That(driver.Url, Is.Not.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
                driver.Navigate().Back();
            }
            driver.Quit();
        }
    }
}