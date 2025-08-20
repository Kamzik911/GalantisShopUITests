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
                    chromeOptions.AddArgument("--headless");
                    return new ChromeDriver(chromeOptions);

                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--headless");
                    return new FirefoxDriver(firefoxOptions);

                case "edge":
                    var edgeOptions = new EdgeOptions();
                    edgeOptions.AddArgument("--headless");
                    return new EdgeDriver(edgeOptions);

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
