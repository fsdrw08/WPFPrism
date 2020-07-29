using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFPrismModels;

namespace NavigationTree.ViewModels
{
    public class NavigationTreeViewModel : BindableBase
    {
        private WPFPrismData appData = null;
        public NavigationTreeViewModel(WPFPrismData testAppData)
        {
            this.appData = testAppData;
        }
    }
}
