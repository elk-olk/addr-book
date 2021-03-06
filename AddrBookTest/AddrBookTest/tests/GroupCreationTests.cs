﻿using System;
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
            app.Navigator.GotoHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GotoGroupsPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.GrHeader = "JJJ";
            group.GrFooter = "RRR";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToGroupsPage();
            app.Auth.Logout();
        }
    }
}
