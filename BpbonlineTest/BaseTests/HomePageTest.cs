using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BpbonlineTestProject.BaseTests
{
    public class HomePageTest : BaseTest
    {
        [Test]
        public void testTest()
        {
           homePage.OpenToHomePage();
            homePage.myAccountBtn.Click();
            Console.WriteLine();
        }

    }
    
}
