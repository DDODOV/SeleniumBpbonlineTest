using BpbonlineTest.Pages;
using OpenQA.Selenium;


namespace BpbonlineTestProject.Pages
{
    public class LogInPage : BasePage
    {
        public LogInPage(IWebDriver driver) : base(driver)
        {
        }
        IWebElement WelcomeMsg => WaitForElement(By.XPath("//div[@id='bodyContent']/h1"));
        IWebElement newCustommerMsg => WaitForElement(By.XPath("//div[@id='bodyContent']/div[1]/h2"));
        IWebElement returningCustommerMsg => WaitForElement(By.XPath("//div[@id='bodyContent']/div[2]/h2"));
        IWebElement continueBtn => WaitForElement(By.Id("tdb4"));
        IWebElement emailInput => WaitForElement(By.XPath("//input[@name='email_address']"));
        IWebElement passwordInput => WaitForElement(By.XPath("//input[@name='password']"));
        IWebElement forgotPasswordLink => WaitForElement(By.XPath("//form[@name='login']/p/a"));
        IWebElement signInBtn => WaitForElement(By.XPath("//button[@id='tdb5']"));
    }
}
