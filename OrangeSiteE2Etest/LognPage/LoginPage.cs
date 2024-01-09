using System;
using OpenQA.Selenium;

namespace OrangeSiteE2Etest
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver) => this.driver = driver;
        public IWebElement username => driver.FindElement(By.Name("username"));
        public IWebElement password => driver.FindElement(By.Name("password"));
        public IWebElement loginbtn => driver.FindElement(By.CssSelector("button[type='submit']"));
        public IWebElement forgotpassword => driver.FindElement(By.CssSelector(".oxd-text.oxd-text--p.orangehrm-login-forgot-header"));
        public IList <IWebElement> links => driver.FindElements(By.CssSelector("svg"));
        public IWebElement errormsg => driver.FindElement(By.TagName("span"));
        public void Login(string Username, string Password)
        {
            username.SendKeys(Username);
            password.SendKeys(Password);
            loginbtn.Click();
        }

        public void Refresh()
        {
            driver.Navigate().Refresh();
        }
    }
}