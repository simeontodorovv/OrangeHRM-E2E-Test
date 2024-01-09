using System;
using OpenQA.Selenium;

namespace OrangeSiteE2Etest
{
    public class ClaimPage
    {
        IWebDriver driver;
        public ClaimPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement claim => driver.FindElement(By.LinkText("Claim"));
        public IWebElement assignClaim => driver.FindElement(By.LinkText("Assign Claim"));
        public IWebElement Name => driver.FindElement(By.CssSelector("input[placeholder='Type for hints...']"));
        public IWebElement Event => driver.FindElement(By.CssSelector("div[class='oxd-layout-context'] div:nth-child(2) div:nth-child(1) div:nth-child(1) div:nth-child(1) div:nth-child(2) div:nth-child(1) div:nth-child(1) div:nth-child(1)"));
        public IWebElement Currency => driver.FindElement(By.CssSelector("div[class='oxd-form-row'] div:nth-child(2) div:nth-child(1) div:nth-child(2) div:nth-child(1) div:nth-child(1) div:nth-child(1)"));
        public IWebElement Remarks => driver.FindElement(By.CssSelector(".oxd-textarea.oxd-textarea--active.oxd-textarea--resize-vertical"));
        public IWebElement Submit => driver.FindElement(By.CssSelector("button[type='submit']"));
        public IList<IWebElement> elementsList = new List<IWebElement>();
        public IWebElement req1 => driver.FindElement(By.CssSelector("body > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > form:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(3)"));
        public IWebElement req2 => driver.FindElement(By.CssSelector("body > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > form:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(3)"));
        public IWebElement req3 => driver.FindElement(By.CssSelector("body > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > form:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > span:nth-child(3)"));
        public void goToClaimPage()
        {
            Dashboard board = new Dashboard(driver);
            board.GoToDashboard();
            claim.Click();
            assignClaim.Click();
        }
        public void createEvent(string name, string Eventt, string currency, string remarks)
        {
            Name.SendKeys(name);
            Event.SendKeys(Eventt);
            Currency.SendKeys(currency);
            Remarks.SendKeys(remarks);
            Submit.Click();
        }
    }
}
