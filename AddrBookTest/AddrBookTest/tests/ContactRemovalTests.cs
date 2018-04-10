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
            app.Navigator.GotoHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GotoHomePage();
            app.Contacts.SelectContact("17");
            app.Contacts. DeleteContact();
            app.CloseAlertAndGetItsText();
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            app.Auth.Logout();
        }
    }
}
