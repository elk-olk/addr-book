using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests :TestBase
    {

        [Test]
        public void TheUntitledTest()
        {
            navigationHelper.GotoHomePage();
            LoginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GotoHomePage();
            SelectContact("14");
            DeleteContact();
            CloseAlertAndGetItsText();
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            LoginHelper.Logout();
        }
    }
}
