using AutomationExamCodeSolvers.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            AppiumDriverFactory.GetDriver();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            AppiumDriverFactory.QuitDriver();
        }
    }
}
