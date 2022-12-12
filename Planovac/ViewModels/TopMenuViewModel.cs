using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;

namespace Planovac.ViewModels
{
    [ObservableObject]
    partial class TopMenuViewModel
    {
        private IMessenger messenger = WeakReferenceMessenger.Default;

        [RelayCommand]
        private void UpdateView(string parameter)
        {
            messenger.Send(new ViewChanged(parameter));
        }

        [RelayCommand]
        private void Save()
        {
            messenger.Send(new SaveRequest());
        }
    }
}
