using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Pages.Mobile
{
    public class LoginScreen : BasePage
    {
        private readonly By UsernameTexfield = By.XPath("//*[@resource-id='ion-input-0']");
        private readonly By PasswordTexfield = By.XPath("//*[@resource-id='ion-input-1']");
        private readonly By SignInButton = By.XPath("//*[@resource-id='btnlogin']");
        public LoginScreen(AppiumDriver driver):base(driver) { }
        public void Login(string username, string password)
        {
            Type(UsernameTexfield, username);
            Type(PasswordTexfield, password);
            Click(SignInButton);
        }
        public bool VerifyLoginScreenElements()
        {
            try
            {
                IsVisible(UsernameTexfield);
                IsVisible(PasswordTexfield);
                IsVisible(SignInButton);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
