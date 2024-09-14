
using BpbonlineTest.Pages;
using BpbonlineTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BpbonlineTestProject.BaseTests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        public LogInPage logInPage;
        public HomePage homePage;
        public ContactUsPage contactUsPage;
        public ForgottenPassPage forgottenPassPage;
        public CreateAccountPage createAccountPage;

        [OneTimeSetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-search-engine-choice-screen");
            options.AddArgument("--no-first-run");
            options.AddArgument("--no-default-browser-check");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-default-apps");
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            homePage = new HomePage(driver);
            logInPage = new LogInPage(driver);
            contactUsPage = new ContactUsPage(driver);
            forgottenPassPage = new ForgottenPassPage(driver);
            createAccountPage = new CreateAccountPage(driver);

        }

        [OneTimeTearDown]
        public void TearDown() 
        {
            driver.Close();
            driver.Dispose();
        }
      
    }
}
