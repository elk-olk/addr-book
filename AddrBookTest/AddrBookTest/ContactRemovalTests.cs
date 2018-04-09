using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests :TestBase
    {

        [Test]
        public void TheUntitledTest()
        {
            navigationHelper.GotoHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GotoHomePage();
            contactHelper.SelectContact("15");
            contactHelper. DeleteContact();
            CloseAlertAndGetItsText();
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            loginHelper.Logout();
        }
    }
}
