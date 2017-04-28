using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_SeleniumTestsHW.Pages.ResizablePage
{
    public static class ResizablePageAsserter
    {
        public static void AssertNewSize(this ResizablePage page, int pixelToWidth, int pixelsToheight)
        {
            Assert.AreEqual(page.Width + 100, page.resizeWindow.Size.Width);
            Assert.AreEqual(page.Height + 100, page.resizeWindow.Size.Height);
        }
    }
}
