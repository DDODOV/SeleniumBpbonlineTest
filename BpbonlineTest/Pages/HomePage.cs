using BpbonlineTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace BpbonlineTestProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement myCartContentBtn => WaitForElement(By.XPath("//span[text()='Cart Contents']"));
        public IWebElement guestMessage => WaitForElement(By.XPath("//div//div[@class='contentText'][1]"));
        public IWebElement logInLink => WaitForElement(By.XPath("//div[@class='contentText']/a[1]"));
        public IWebElement createAccount => WaitForElement(By.XPath("//div[@class='contentText']/a[2]"));
        public IWebElement myAccountLink => WaitForElement(By.XPath("//span[text()='My Account']"));

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

    }
}
