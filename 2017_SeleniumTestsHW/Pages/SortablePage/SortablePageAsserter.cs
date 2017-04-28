using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_SeleniumTestsHW.Pages.SortablePage
{
    public static class SortablePageAsserter
    {
        public static void AssertSortablePageIsOpen(this SortablePage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }
    }
}
