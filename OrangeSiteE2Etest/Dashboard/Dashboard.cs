using System;
using OpenQA.Selenium;

namespace OrangeSiteE2Etest
{
    public class Dashboard
    {
        IWebDriver driver;
        public Dashboard(IWebDriver driver) => this.driver = driver;
        public IList<IWebElement> myActions => driver.FindElements(By.CssSelector(".orangehrm-todo-list-item"));
        public IList<IWebElement> quickLaunch => driver.FindElements(By.CssSelector("button.oxd-icon-button.orangehrm-quick-launch-icon"));
        public IWebElement username => driver.FindElement(By.Name("username"));
        public IWebElement password => driver.FindElement(By.Name("password"));
        public IWebElement loginbtn => driver.FindElement(By.CssSelector("button[type='submit']"));


        public void GoToDashboard()
        {
            username.SendKeys("Admin");
            password.SendKeys("admin123");
            loginbtn.Click();
        }
    }
}