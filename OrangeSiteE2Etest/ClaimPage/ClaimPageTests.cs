using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace OrangeSiteE2Etest
{
    [TestFixture, Order(3)]
    public class ClaimPageTests : Setup
    {
        [Test, Order(1)]
        public void GoToPageTest()
        {
            ClaimPage page = new ClaimPage(driver);
            page.goToClaimPage();
        }
        [Test, Order(2)]
        public void CreateEventWithEmptyFields()
        {
            ClaimPage page = new ClaimPage(driver);
            page.Submit.Click();
            Assert.That
            (new[] { page.req1.Text, page.req2.Text, page.req3.Text }, 
            Is.EqualTo(new[] { "Required", "Required", "Required" }));
        }
        [Test, Order(2)]
        public void CreateEventOnlyWithName()
        {
            ClaimPage page = new ClaimPage(driver);
            page.Name.SendKeys("Lisa");
            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            page.Submit.Click();
            Assert.That
            (new[] { page.req1.Text, page.req3.Text }, 
            Is.EqualTo(new[] { "Required", "Required" }));
        }
        [Test, Order(3)]
        public void CreateEventWithValidData()
        {
            ClaimPage page = new ClaimPage(driver);
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            page.Submit.Click();
            SelectElement eventField = new SelectElement(page.Event);
            eventField.SelectByValue("option1");
            SelectElement currencyField = new SelectElement(page.Currency);
            currencyField.SelectByValue("option1");
            page.Submit.Click();
        }
        



    }
}