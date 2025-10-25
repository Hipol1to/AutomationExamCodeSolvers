using AutomationExamCodeSolvers.Features;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Pages.Mobile
{
    public class DashboardScreen : BasePage
    {
        private readonly By WarehouseReceiptsButton = By.XPath("//android.view.View[@text=\"Warehouse Receipts\"]");
        private readonly By BurguerMenuButton = By.XPath("//android.widget.Button[@content-desc=\"menu\"]");
        private readonly By LogoutOption = By.XPath("//android.widget.TextView[@text=\"Logout\"]");
        public DashboardScreen(AppiumDriver driver):base(driver) { }
        public void NavigateToWarehouseReceiptsScreen()=> Click(WarehouseReceiptsButton);
     
        public void LogOut()
        {
            Click(BurguerMenuButton);
            ScrollDownBurguerMenu();
            Click(LogoutOption);
        }
        protected void ScrollDownBurguerMenu()
        {
            var size = Driver.Manage().Window.Size;
            int startX = size.Width / 2 - 100;
            int startY = (int)(size.Height * 0.6);
            int endY = (int)(size.Height * 0.3);

            var touch = new PointerInputDevice(PointerKind.Touch, "finger1");
            var swipe = new ActionSequence(touch, 0);

            swipe.AddAction(touch.CreatePointerMove(CoordinateOrigin.Viewport, startX, startY, TimeSpan.Zero));
            swipe.AddAction(touch.CreatePointerDown(MouseButton.Left));
            swipe.AddAction(touch.CreatePointerMove(CoordinateOrigin.Viewport, startX, endY, TimeSpan.FromMilliseconds(400)));
            swipe.AddAction(touch.CreatePointerUp(MouseButton.Left));

            Driver.PerformActions(new List<ActionSequence> { swipe });
        }
    }
}
