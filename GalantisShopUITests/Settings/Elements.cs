
namespace GalantisShopUITests.Settings
{
    public class Elements : Methods
    {
        private static readonly string galantisMainPageLogo = "div[class='header-logo-container']";
        private readonly string wievAllMainPageButton = "a[class='p-2 nav-item view-all']";

        public void CleanUpAfterTest()
        {
            CleanWebDriver();
            KillChromeDriverProcess();
        }

        public void ClickOnMainPageLogo()
        {
            ClickCssElement(galantisMainPageLogo);
        }

        public void ClickOnWievAllMainPageButton()
        {
            ClickCssElement(wievAllMainPageButton);
        }
    }
}
