using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Pages.Mobile
{
    public class NetworkIdSetupScreen : BasePage
    {
        private readonly By ScreenTitle = By.XPath("//android.widget.TextView[@text=\"Enter the 5-digit ID of your logistics partner\"]");
        private readonly By NetworkIdInputField = By.ClassName("android.widget.EditText");
        public NetworkIdSetupScreen(AppiumDriver driver) : base(driver)
        {}
        public void SetCompanyNetworkId(string companyNetworkId) 
        {
            Click(NetworkIdInputField);
            Type(NetworkIdInputField, companyNetworkId);
            Thread.Sleep(500);
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.Enter).Perform();
        }
    }
}
