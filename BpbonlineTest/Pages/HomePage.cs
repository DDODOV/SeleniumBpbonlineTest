using BpbonlineTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;


namespace BpbonlineTestProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement cartContentBtn => WaitForElement(By.XPath("//a[@id='tdb1']"));
        public IWebElement checkOutBtn => WaitForElement(By.XPath("//a[@id='tdb2']"));
        public IWebElement myAccountBtn => WaitForElement(By.XPath("//a[@id='tdb3']"));
        public IWebElement quickFindSearchBox => WaitForElement(By.XPath("//input[@name='keywords']"));
        public IWebElement quickFindBtn => WaitForElement(By.XPath("//input[@alt='Quick Find']"));
        public IWebElement contactUsBtn => WaitForElement(By.XPath("//a[text()='Contact Us']"));
       
        public void OpenToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void DropDownMenuOption(string option)
        {
            IWebElement dropDownMenu = WaitForElement(By.XPath("//select[@name='manufacturers_id']"));

            var selectElement = new SelectElement(dropDownMenu);

            selectElement.SelectByText(option);
        }
    }
}
