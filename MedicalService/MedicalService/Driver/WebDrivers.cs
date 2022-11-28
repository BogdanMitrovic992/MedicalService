using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MedicalService.Driver
{
    public class WebDrivers
    {
        public static IWebDriver? Instance { get; set; }

        public static void Initialization()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Navigate().GoToUrl("https://katalon-demo-cura.herokuapp.com/");

        }

        public static void CleanUo()
        {
            Instance?.Quit();
        }
    }  }
