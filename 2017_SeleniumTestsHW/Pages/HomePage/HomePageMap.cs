using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace _2017_SeleniumTestsHW.Pages.HomePage
{
    public partial class HomePage
    {
        [FindsBy(How = How.Id, Using = "menu-item-374")]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-140")]
        public IWebElement DraggableButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-141")]
        public IWebElement DroppableButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-143")]
        public IWebElement ResizableButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-142")]
        public IWebElement SelectableButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-151")]
        public IWebElement SortableButton { get; set; }

    }
}
