﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_SeleniumTestsHW.Pages.ResizablePage
{
    public static class ResizablePage : BasePage
    {
        private int width;
        private int height;

        public ResiblePage(IWebDriver driver) : base(driver)
        {
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public string URL
        {
            get
            {
                return base.url + "resizable/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }

        public void IncreaseWidthAndheightBy(int increaseSize)
        {
            this.NavigateTo();
            this.width = this.resizeWindow.Size.Width;
            this.height = this.resizeWindow.Size.Height;
            Actions builder = new Actions(this.Driver);
            var resize = builder.DragAndDropToOffset(this.resizeButton, increaseSize, increaseSize);
            resize.Perform();
        }
    }
}
