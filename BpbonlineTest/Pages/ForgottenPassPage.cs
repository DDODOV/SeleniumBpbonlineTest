using BpbonlineTest.Pages;
using OpenQA.Selenium;


namespace BpbonlineTestProject.Pages
{
    public class ForgottenPassPage : BasePage
    {
        public ForgottenPassPage(IWebDriver driver) : base(driver)
        {
        }
        IWebElement backBtn => WaitForElement(By.XPath("//a[@id='tdb5']"));
        IWebElement continueBtn => WaitForElement(By.XPath("//button[@id='tdb4']"));
        IWebElement emailInput => WaitForElement(By.XPath("//input[@name='email_address']"));
        IWebElement errorMsg => WaitForElement(By.XPath("//td[@class='messageStackError']"));
        IWebElement forgotPassMsg => WaitForElement(By.XPath("//div[@class='contentText']"));
    }
}
