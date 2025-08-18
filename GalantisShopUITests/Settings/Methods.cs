using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace GalantisShopUITests.Settings
{
    public class Methods : WebDriverSetup
    {
        WebPages webPages = new WebPages();        
        WebDriver webDriver = new WebDriverSetup().SelectWebDriver("chrome");        
                
        public void BrowserWindowMaximize()
        {            
            webDriver.Manage().Window.Maximize();
        }

        public void GoToHomeWebPage()
        {            
            webDriver.Navigate().GoToUrl(webPages.homeWebsite);
        }

        public void WaitForCssElement(string cssElement)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.CssSelector(cssElement)));
        }

        public void ClickCssElement(string cssElement)
        {
            WaitForCssElement(cssElement);
            webDriver.FindElement(By.CssSelector(cssElement)).Click();
        }       

        public void CleanChromeDriver()
        {
            var process = Process.GetProcessesByName("chromedriver");
            
            if (webDriver != null)
            {
                webDriver.Close();
                webDriver.Quit();
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
                }
                catch { }
            }
        }
    }
}
