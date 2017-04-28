using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_SeleniumTestsHW.Pages.ResizablePage
{
    public static class ResizablePageMap
    {
        public partial class ResiblePage
        {
            public IWebElement resizeButton
            {
                get
                {
                    return this.Driver.FindElement(By.XPath(""));
                }
            }

            public IWebElement resizeWindow
            {
                get
                {
                    return this.Driver.FindElement(By.Id(""));
                }
            }
        }
    }
}
