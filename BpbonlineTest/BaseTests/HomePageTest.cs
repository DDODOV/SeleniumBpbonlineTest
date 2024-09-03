using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace BpbonlineTestProject.BaseTests
{
    public class HomePageTest : BaseTest
    {
        [Test]
        public void VerifyGuestMesg_ShouldSucceed()
        {
            homePage.NavigateToHomePage();
            var expextedMsg = "Welcome Guest! Would you like to log yourself in? Or would you prefer to create an account?";
            Assert.That(homePage.guestMessage.Text, Is.EqualTo(expextedMsg),"Not on the Home Page");
        }

        [Test]
        public void VerifyLogInLinkIsWroking_ShouldSucceed()
        {
            var expectedUrl = "https://practice.bpbonline.com/login.php";
            homePage.NavigateToHomePage();

            homePage.logInLink.Click();

            var textToBePresent = driver.FindElement(By.XPath("//div[@id='bodyContent']/h1")).Text;

            Assert.That(driver.Url, Contains.Substring(expectedUrl),"Not on the LogInPage");

            Assert.That(textToBePresent, Is.EqualTo("Welcome, Please Sign In"),"Expected text doen't match the actual");
        }

        [Test]
        public void VerifyRegisterLinkIsWroking_ShouldSucceed()
        {
            var expectedUrl = "https://practice.bpbonline.com/create_account.php";
            homePage.NavigateToHomePage();

            homePage.createAccount.Click();

            var textToBePresent = driver.FindElement(By.XPath("//div[@id='bodyContent']/h1")).Text;

            Assert.That(driver.Url, Contains.Substring(expectedUrl), "Not on the LogInPage");

            Assert.That(textToBePresent, Is.EqualTo("My Account Information"), "Expected text doen't match the actual");
        }
        [Test]
        public void MyAccountLinkIsWorking_ShouldSuceed()
        {
            homePage.NavigateToHomePage();

            homePage.myAccountLink.Click();

            var textToBePresent = driver.FindElement(By.XPath("//div[@id='bodyContent']/h1")).Text;

            Assert.That(textToBePresent, Is.EqualTo("Welcome, Please Sign In"), "Expected text doen't match the actual");
        }

    }
    
}
