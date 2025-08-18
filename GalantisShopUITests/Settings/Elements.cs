using System.Xml.Linq;

namespace GalantisShopUITests.Settings
{
    public class Elements : Methods
    {
        public readonly string galantisMainPageLogo = "div[class='header-logo-container']";

        public void CleanUpAfterTest()
        {
            CleanChromeDriver();
            KillChromeDriverProcess();
        }

        public void ClickOnMainPageLogo()
        {
            ClickCssElement(galantisMainPageLogo);
        }        
    }
}
