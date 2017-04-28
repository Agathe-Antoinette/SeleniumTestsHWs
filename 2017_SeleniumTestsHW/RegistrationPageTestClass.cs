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

namespace _2017_SeleniumTestsHW
{
    [TestFixture]
    public class RegistrationPageTestClass
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
        public void NavigateToRegistrationPage()
        {
            var homePage = new HomePage(driver);
            var registrationPage = new RegistrationPage(driver);

            homePage.NavigateTo();
            homePage.RegistrationButton.Click();

            registrationPage.AssertRegistrationPageIsOpen("Registration");
        }


        [Test]
        public void RegistrateWithValidData()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        [Test]
        public void RegistrateWithNoData()
        {
            var regPage = new RegistrationPage(this.driver);
            //RegistrationUser user = new RegistrationUser("",
            //                                             "",
            //                                             new List<bool>(new bool[] {}),
            //                                             new List<bool>(new bool[] {}),
            //                                             "",
            //                                             "",
            //                                             "",
            //                                             "",
            //                                             "",
            //                                             "",
            //                                             "",
            //                                             @"",
            //                                             "",
            //                                             "",
            //                                             "");
            RegistrationUser user = new RegistrationUser() {
                FirstName = "AAA",
                LastName = "",
                MaritalStatus = new List<bool>(new bool[] { }),
                Hobbys = new List<bool>(new bool[] { })
            };

            //RegistrationUser user1 = new RegistrationUser(
            //    maritalStatus: new List<bool>(new bool[] { }),
            //    hobbys: new List<bool>(new bool[] { })
            //);

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertNamesErrorMessage("This field is required");
            regPage.AssertHobbyErrorMessage("This field is required");
            regPage.AssertPhoneErrorMessage("This field is required");
            regPage.AssertUsernameErrorMessage("This field is required");
            regPage.AssertEmailErrorMessage("This field is required");
            regPage.AssertPasswordErrorMessage("This field is required");
            regPage.AssertConfirmPasswordErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutFirstName()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertNamesErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutLastName()
        {
            var regPage = new RegistrationPage(this.driver);
            String profilePicturePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Resources\Nakov-face.jpg");
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertNamesErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutMaritalStatus()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] {}),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        [Test]
        public void RegistrateWithoutPhoneNumber()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPhoneErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutHobby()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertHobbyErrorMessage("This field is required");
        }


        [Test]
        public void RegistrateWithoutCountry()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        [Test]
        public void RegistrateWithoutBirthDay()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        [Test]
        public void RegistrateWithoutBirthMonth()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        [Test]
        public void RegistrateWithOutBirthYear()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        [Test]
        public void RegistrateWithoutEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertEmailErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutUsername()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertUsernameErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithoutConfirmationPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertConfirmPasswordErrorMessage("This field is required");
        }

        [Test]
        public void RegistrateWithTooShortPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "1234",
                                                         "1234");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertPasswordErrorMessage("Minimum 8 characters required");
        }

        [Test]
        public void RegistrateWithoMismatchedPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345687");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertConfirmPasswordErrorMessage("Fields do not match");
        }


        [Test]
        public void RegistrateWithoutPicture()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"",
                                                         "Intrigue: noun. the series of complications forming the plot of a play",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }


        [Test]
        public void RegistrateWithoutAbout()
        {
            var regPage = new RegistrationPage(this.driver);
            RegistrationUser user = new RegistrationUser("Agatha",
                                                         "Luis",
                                                         new List<bool>(new bool[] { true, false, false }),
                                                         new List<bool>(new bool[] { true, true, true }),
                                                         "Bahrain",
                                                         "6",
                                                         "11",
                                                         "1992",
                                                         "7777777777",
                                                         "agathaluis",
                                                         "agataluis@gmail.com",
                                                         @"Resources\Nakov-face.jpg",
                                                         "",
                                                         "12345678",
                                                         "12345678");

            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);

            regPage.AssertSuccessMessage("Thank you for your registration");
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
