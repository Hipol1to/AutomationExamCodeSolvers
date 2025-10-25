using AutomationExamCodeSolvers.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Drivers
{
    public static class AppiumDriverFactory
    {
        private static AppiumDriver? _driver;
        public static AppiumDriver GetDriver()
        {
            if (_driver != null)
            {
                return _driver;
            }
            var config = ConfigReader.GetConfig();
            var options = new AppiumOptions();
            options.DeviceName = config[Constants.DeviceName]!.ToString();
            options.PlatformVersion = config[Constants.PlatformVersion]!.ToString();
            options.AutomationName = config[Constants.AutomationName]!.ToString();
            options.AddAdditionalAppiumOption(Constants.AppPackage, config[Constants.AppPackage]!.ToString());
            options.AddAdditionalAppiumOption(Constants.AppActivity, config[Constants.AppActivity]!.ToString());
            options.AddAdditionalAppiumOption(Constants.AutoGrantPermissions, true);
            _driver = new AndroidDriver(new Uri(Constants.AppiumServerUrl), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.DefaultImplicitWait);
            return _driver;
        }
        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
