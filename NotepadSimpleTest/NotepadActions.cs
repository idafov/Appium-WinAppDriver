using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public partial class NotepadView
    {
        private readonly WindowsDriver<WindowsElement> _driver;
        public NotepadView(WindowsDriver<WindowsElement> driver) => _driver = driver;

        public void TypeAndChangeFont()
        {
            WriteField.Click();
            WriteField.SendKeys("bla-bla-bla, Radinovo 2018");
            Format.Click();
            Font.Click();
            CooperFont.Click();
            OKbutton.Click();

        }
    }
}
