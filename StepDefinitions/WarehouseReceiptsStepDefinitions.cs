using AutomationExamCodeSolvers.Drivers;
using AutomationExamCodeSolvers.Pages.Mobile;
using OpenQA.Selenium.Appium;
using Reqnroll;
using System;

namespace AutomationExamCodeSolvers.StepDefinitions
{
    [Binding]
    public class WarehouseReceiptsStepDefinitions
    {
        private readonly AppiumDriver _driver;
        private readonly NetworkIdSetupScreen _networkIdSetupScreen;
        private readonly LoginScreen _loginScreen;
        private readonly DashboardScreen _dashboardScreen; 
        private readonly WarehouseRececiptsScreen _warehouseRececiptsScreen; 
        private readonly WarehouseReceiptsFiltersScreen _warehouseReceiptsFiltersScreen;
        public WarehouseReceiptsStepDefinitions() {
            _driver = AppiumDriverFactory.GetDriver();
            _networkIdSetupScreen = new NetworkIdSetupScreen(_driver);
            _loginScreen = new LoginScreen(_driver);
            _dashboardScreen = new DashboardScreen(_driver);
            _warehouseRececiptsScreen = new WarehouseRececiptsScreen(_driver);
            _warehouseReceiptsFiltersScreen = new WarehouseReceiptsFiltersScreen(_driver);
        }

        [Given("user is logged in with NetworkId {string}, Username {string}, and Password {string}")]
        public void GivenUserIsLoggedInWithNetworkIdUsernameAndPassword(string networkId, string username, string password)
        {
            _networkIdSetupScreen.SetCompanyNetworkId(networkId);
            _loginScreen.Login(username, password);
        }


        [When("user navigates to warehouse receipts module")]
        public void WhenUserNavigatesToWarehouseReceiptsModule()
        {
            _dashboardScreen.NavigateToWarehouseReceiptsScreen();
        }

        [When("user applies OnHand status filter")]
        public void WhenUserAppliesOnHandStatusFilter()
        {
            Thread.Sleep(500);
            _warehouseRececiptsScreen.NavigateToFiltersScreen();
            Thread.Sleep(500);
            _warehouseReceiptsFiltersScreen.ApplyOnHandFilter();
        }

        [Then("the app should show records with On Hand status")]
        public void ThenTheAppShouldShowRecordsWithOnHandStatus()
        {
            bool areReceiptsVisible = _warehouseRececiptsScreen.VerifyARecordIsVisible();
            Assert.IsTrue(areReceiptsVisible);
        }

        [Then("user should be on login screen after logging out")]
        public void ThenUserShouldBeOnLoginScreenAfterLoggingOut()
        {
            _warehouseRececiptsScreen.NavigateToDashboardScreen();
            _dashboardScreen.LogOut();
            bool isUserAtLoginScreen = _loginScreen.VerifyLoginScreenElements();
            Assert.IsTrue(isUserAtLoginScreen);
        }
    }
}
