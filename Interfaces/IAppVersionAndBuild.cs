using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LEDiBond.Interfaces
{
    public class IAppVersionAndBuild
    {
        public string GetVersionNumber()
        {
            return typeof(App).GetTypeInfo().Assembly.GetName().Version.ToString();
        }
        public string GetBuildNumber()
        {
            return typeof(App).GetTypeInfo().Assembly.GetName().Version.Build.ToString();
        }
    }
}
