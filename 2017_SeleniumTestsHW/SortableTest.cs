using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2017_SeleniumTestsHW.Models;
using _2017_SeleniumTestsHW.Pages.HomePage;
using _2017_SeleniumTestsHW.Pages.RegistrationPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using _2017_SeleniumTestsHW.Pages.SortablePage;

namespace _2017_SeleniumTestsHW
{
    [TestFixture]
    public class SortableTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new FirefoxDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("Priority", 2)]
        [Author("Antoaneta Petkova")]
        public void NavigateToSortablePage()
        {
            var homePage = new HomePage(driver);
            var sortablePage = new SortablePage(driver);

            homePage.NavigateTo();
            homePage.SortableButton.Click();

            sortablePage.AssertSortablePageIsOpen("Sortable");
        }
    }
}
