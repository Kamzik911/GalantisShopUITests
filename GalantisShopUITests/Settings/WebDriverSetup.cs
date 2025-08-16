using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace GalantisShopUITests.Settings
{    
    public class WebDriverSetup
    {
        public static WebDriver WebDriverOptions(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    return new ChromeDriver(chromeOptions);

                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    return new FirefoxDriver(firefoxOptions);

                case "edge":
                    var edgefoxOptions = new EdgeOptions();
                    return new EdgeDriver(edgefoxOptions);

                default:
                    throw new ArgumentException($"Browser not supported: {browserName}");
            }            
        }

        public WebDriver SelectWebDriver(string browser)
        {
            return WebDriverOptions(browser);
        }
    }
}
