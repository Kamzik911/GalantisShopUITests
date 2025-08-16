using GalantisShopUITests.Settings;
using OpenQA.Selenium;
using System.Diagnostics;

namespace GalantisShopUITests
{
    [TestClass]
    public sealed class Tests : Methods
    {
        Elements elements = new Elements();

        [TestInitialize]
        public void TestInit()
        {
            BrowserWindowMaximize();
        }

        [TestMethod]
        public void CheckMainPageGalantisLogo()
        {
            GoToHomeWebPage();
            ClickOnCssElement(elements.galantisMainPageLogo);
            KillChromeDriver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            KillChromeDriver();
        }
    }
}
