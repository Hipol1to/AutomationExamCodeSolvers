using AutomationExamCodeSolvers.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Pages.Mobile
{
    public abstract class BasePage
    {
        protected readonly AppiumDriver Driver;
        protected readonly WebDriverWait Wait;
        protected BasePage(AppiumDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(ConfigReader.GetImplicitTimeout()));
        }
        protected void Click(By locator)
        {
            Wait.Until(d => d.FindElement(locator).Displayed);
            Driver.FindElement(locator).Click();
        }
        protected void Type(By locator)
        {
            Wait.Until(d => d.FindElement(locator).Displayed);
            Driver.FindElement(locator).Click();
        }
        protected bool IsVisible(By locator)
        {
            try
            {
                return Driver.FindElement(locator).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
