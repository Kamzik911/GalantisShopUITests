using GalantisShopUITests.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Communication;

namespace GalantisShopUITests
{
    [TestClass]
    public sealed class Tests : Elements
    {
        [DataTestMethod]
        [DataRow("chrome")]
        [DataRow("edge")]        
        public void ClickMainPageGalantisLogo_Pass(string browser)
        {
            StartBrowser(browser);
            GoToHomeWebPage(browser);
            ClickOnMainPageLogo();            
        }

        //[DataTestMethod]
        //[DataRow("chrome")]
        //[DataRow("edge")]        
        public void ClickOnWievAllMainPageButton_Pass(string browser)
        {
            StartBrowser(browser);
            GoToHomeWebPage(browser);
            ClickOnWievAllMainPageButton();
        }

        [TestCleanup]
        public void Cleanup() 
        {
            CleanUpAfterTest();
        }
    }
}
