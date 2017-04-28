using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _2017_SeleniumTestsHW.Pages.SortablePage
{
    public partial class SortablePageMap : BasePage
    {
        public IWebElement Title
        {
            get
            {
                return this.Driver.FindElement(By.TagName("title"));
            }
        }

        public IWebElement Header
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("entry-title"));
            }
        }
        public IWebElement FirstName
        {
            get
            {
                return this.Driver.FindElement(By.Id(""));
            }
        }

    }
}
