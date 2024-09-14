

using BpbonlineTest.Pages;
using OpenQA.Selenium;

namespace BpbonlineTestProject.Pages
{
    public class CreateAccountPage : BasePage
    {
        public CreateAccountPage(IWebDriver driver) : base(driver)
        {
        }
        IWebElement genderMale => WaitForElement(By.XPath("//input[@value='m']"));
        IWebElement genderFemale => WaitForElement(By.XPath("//input[@value='f']"));
        IWebElement firstNameInput => WaitForElement(By.XPath("//input[@name='firstname']"));
        IWebElement lastNameInpit => WaitForElement(By.XPath("//input[@name='lastname']"));
        IWebElement dateOfbirth => WaitForElement(By.Id("dob"));
        IWebElement mailInput => WaitForElement(By.XPath("//input[@name='email_address']"));
        IWebElement companyNameInput => WaitForElement(By.XPath("//input[@name='company']"));
        IWebElement streetAdressInput => WaitForElement(By.XPath("//input[@name='street_address']"));
        IWebElement suburbInput => WaitForElement(By.XPath("//input[@name='suburb']"));
        IWebElement postCodeInput => WaitForElement(By.XPath("//input[@name='postcode']"));
        IWebElement cityInput => WaitForElement(By.XPath("//input[@name='city']"));
        IWebElement stateInput => WaitForElement(By.XPath("//input[@name='state']"));
        IWebElement dropDownMenuContries => WaitForElement(By.XPath("//select[@name='country']"));

    }
}
