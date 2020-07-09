using LEDiBond.Interfaces;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LEDiBond.ViewModels
{
    public class AboutPopupPageViewModel : ViewModelBase
    {

        string _versionNumber;
        public string VersionNumber
        {
            get { return _versionNumber; }
            set { SetProperty(ref _versionNumber, value); }
        }

        public AboutPopupPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            VersionNumber = "Version " + AppInfo.VersionString;
        }
    }
}
