using System;
using Reqnroll;

namespace AutomationExamCodeSolvers.StepDefinitions
{
    [Binding]
    public class WarehouseReceiptsStepDefinitions
    {
        [Given("user is logged in with NetworkId {string}, Username {string}, and Password {string}")]
        public void GivenUserIsLoggedInWithNetworkIdUsernameAndPassword(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }


        [When("user navigates to warehouse receipts module")]
        public void WhenUserNavigatesToWarehouseReceiptsModule()
        {
            throw new PendingStepException();
        }

        [When("user applies OnHand status filter")]
        public void WhenUserAppliesOnHandStatusFilter()
        {
            throw new PendingStepException();
        }

        [Then("the app should show records with On Hand status")]
        public void ThenTheAppShouldShowRecordsWithOnHandStatus()
        {
            throw new PendingStepException();
        }

        [Then("user should be on login screen after logging out")]
        public void ThenUserShouldBeOnLoginScreenAfterLoggingOut()
        {
            throw new PendingStepException();
        }
    }
}
