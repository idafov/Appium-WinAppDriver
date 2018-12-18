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
        public WindowsElement WriteField => _driver.FindElementByClassName("Edit");
        public WindowsElement Format => _driver.FindElementByName("Format");
        public WindowsElement Font => _driver.FindElementByName("Font...");
        public WindowsElement CooperFont => _driver.FindElementByName("Cooper");
        public WindowsElement OKbutton => _driver.FindElementByName("OK");
    }
}
