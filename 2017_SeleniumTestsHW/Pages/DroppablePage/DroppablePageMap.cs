using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_SeleniumTestsHW.Pages.DroppablePage
{
        public partial class DroppablePage : BasePage
        {
            public IWebElement Source
            {
                get
                {
                    return this.Driver.FindElement(By.XPath(""));
                }
            }

            public IWebElement Target
            {
                get
                {
                    return this.Driver.FindElement(By.Id(""));
                }
            }
        }
    }
