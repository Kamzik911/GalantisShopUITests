using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace GalantisShopUITests.Settings
{
    public class Methods : WebDriverSetup
    {
        WebPages webPages = new WebPages();        
        WebDriver webDriver = new WebDriverSetup().SelectWebDriver("chrome");        

        public void WaitForElement()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
        public void BrowserWindowMaximize()
        {
            WaitForElement();
            webDriver.Manage().Window.Maximize();
        }
        public void GoToHomeWebPage()
        {
            WaitForElement();
            webDriver.Navigate().GoToUrl(webPages.homeWebsite);
        }

        public void ClickOnCssElement(string cssElement)
        {
            WaitForElement();
            webDriver.FindElement(By.CssSelector(cssElement)).Click();
        }

        public void ClickOnIdElement(string idElement)
        {
            WaitForElement();
            webDriver.FindElement(By.Id(idElement)).Click();
        }

        public void ClickOnNameElement(string nameElement)
        {
            WaitForElement();
            webDriver.FindElement(By.Name(nameElement)).Click();
        }

        public void ClickOnXPathElement(string xPathElement)
        {
            WaitForElement();
            webDriver.FindElement(By.XPath(xPathElement)).Click();
        }

        public void KillChromeDriver()
        {        
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                try
                {
                    process.Kill();
                }
                catch
                {
                    { /* ignore if already closed */ }
                }
            }        
        }
    }
}
