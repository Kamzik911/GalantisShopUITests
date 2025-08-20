using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace GalantisShopUITests.Settings
{
    public class Methods : WebDriverSetup
    {
        //protected WebDriver webDriver = new WebDriverSetup().SelectWebDriver("chrome");        
        protected WebDriver webDriver;

        public void StartBrowser(string browser)
        {
            webDriver = WebDriverOptions(browser);
        }

        public void BrowserWindowMaximize()
        {
            webDriver.Manage().Window.Maximize();
        }

        public void GoToHomeWebPage(string browser)
        {
            webDriver.Navigate().GoToUrl(WebPages.homeWebsite);
        }
        // Waitings
        public void WaitForCssElement(string cssElement)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.CssSelector(cssElement)));
        }

        // Click on elements
        public void ClickCssElement(string cssElement)
        {
            WaitForCssElement(cssElement);
            webDriver.FindElement(By.CssSelector(cssElement)).Click();
        }       

        // Clean webDriver after test
        public void CleanWebDriver()
        {            
            if (webDriver != null)
            {
                webDriver.Close();                
            }
            else
            {
                throw new Exception("Browser window is open");
            }
        }

        public void KillChromeDriverProcess()
        {
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    { }
                }
            }
        }
    }
}
