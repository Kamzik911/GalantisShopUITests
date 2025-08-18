using GalantisShopUITests.Settings;
using OpenQA.Selenium;
using System.Diagnostics;

namespace GalantisShopUITests
{
    [TestClass]
    public sealed class Tests : Elements
    {
        [TestInitialize]
        public void TestInit()
        {
            BrowserWindowMaximize();
        }

        [TestMethod]
        public void CheckMainPageGalantisLogo()
        {
            GoToHomeWebPage();
            ClickOnMainPageLogo();            
        }

        [TestCleanup]
        public void Cleanup() 
        {
            CleanUpAfterTest();
        }
    }
}
