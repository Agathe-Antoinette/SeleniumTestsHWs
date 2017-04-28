using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _2017_SeleniumTestsHW.Pages.SortablePage
{
    class SortablePage
    {
        private IWebDriver driver;

        public SortablePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
