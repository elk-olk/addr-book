using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class TestBase
    {
        //protected IWebDriver driver;
        //private StringBuilder verificationErrors;
        //protected LoginHelper loginHelper;
        //protected NavigationHelper navigationHelper;
        //protected GroupHelper groupHelper;
        //protected ContactHelper contactHelper;
        //protected HelperBase helperBase;
        //protected string baseURL;

        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
