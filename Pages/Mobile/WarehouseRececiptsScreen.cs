using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Pages.Mobile
{
    public class WarehouseRececiptsScreen : BasePage
    {
        private readonly By WarehouseReceiptRecord = By.XPath("//android.view.View[@text and not(.//android.view.View[@text]) and contains(@text,'WH')]");
        private readonly By FilterButton = By.XPath("//*[@class='android.widget.Button' and(not(contains(@content-desc,'menu')))and(not(contains(@content-desc,'back')))]");
        private readonly By BackButton = By.XPath("//android.widget.Button[@content-desc=\"back\"]");
        public WarehouseRececiptsScreen(AppiumDriver driver) : base(driver) { }
        public bool VerifyARecordIsVisible() => IsVisible(WarehouseReceiptRecord);
        public void NavigateToFiltersScreen() => Click(FilterButton);
        public void NavigateToDashboardScreen() => Click(BackButton);
    }
    public class WarehouseReceiptsFiltersScreen : BasePage
    {
        private readonly By StatusFilter = By.XPath("(//*[@resource-id='select-label'])[1]");
        private readonly By StatusOnHandOption = By.XPath("//android.widget.Button[@text=\"On Hand\"]");
        private readonly By ApplyButton = By.XPath("//android.widget.Button[@text=\"Apply\"]");
        public WarehouseReceiptsFiltersScreen(AppiumDriver driver) : base(driver) { }
        public void ApplyOnHandFilter()
        {
            Click(StatusFilter);
            Click(StatusOnHandOption);
            Click(ApplyButton);
        }
    }

}
