using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            navigationHelper.GotoHomePage();
            LoginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GotoGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
            LoginHelper.Logout();
        }
    }
}
