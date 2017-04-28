using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _2017_SeleniumTestsHW.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }

        public static void AssertSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }

        public static void AssertNamesErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNames.Text);
        }

        public static void AssertHobbyErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForHobby.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForHobby.Text);
        }

        public static void AssertPhoneErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
        }

        public static void AssertUsernameErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForUsername.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForUsername.Text);
        }

        public static void AssertEmailErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForEmail.Text);
        }

        public static void AssertPasswordErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPassword.Text);
        }

        public static void AssertConfirmPasswordErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForConfirmPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForConfirmPassword.Text);
        }

    }
}
