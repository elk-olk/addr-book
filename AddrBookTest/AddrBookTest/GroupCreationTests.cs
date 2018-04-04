using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests

{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.GotoHomePage();
            LoginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GotoGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.GrHeader = "JJJ";
            group.GrFooter = "RRR";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            LoginHelper.Logout();
        }
    }
}
