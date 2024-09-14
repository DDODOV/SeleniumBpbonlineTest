using BpbonlineTest.Pages;
using OpenQA.Selenium;


namespace BpbonlineTestProject.Pages
{
    public class ContactUsPage : BasePage 
    {
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
        }
        IWebElement fullNameInput => WaitForElement(By.XPath("//input[@name='name']"));
        IWebElement emailInput => WaitForElement(By.XPath("//input[@name='email']"));
        IWebElement enquiryInput => WaitForElement(By.XPath("//textarea[@name='enquiry']"));
        IWebElement submitContinueBtn => WaitForElement(By.XPath("//span[text()='Continue']"));
        IWebElement enquieryMsg => WaitForElement(By.XPath("//div[@class='contentText']"));
        //Your enquiry has been successfully sent to the Store Owner.
        IWebElement continueBtn => WaitForElement(By.XPath("//a[@id='tdb4']"));
    }
}
