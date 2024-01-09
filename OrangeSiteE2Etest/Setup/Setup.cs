using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeSiteE2Etest
{
    public class Setup
    {
       public IWebDriver driver;
       
       [OneTimeSetUp]
       public void SetUp()
       {
           this.driver = new ChromeDriver();
           driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
           driver.Manage().Window.Maximize();
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
       }

       [OneTimeTearDown]
       public void TearDown()
       {
           // driver.Quit();
       }
    }
}