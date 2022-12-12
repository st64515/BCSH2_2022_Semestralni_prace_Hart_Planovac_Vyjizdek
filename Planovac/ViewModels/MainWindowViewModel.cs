using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System;

namespace Planovac.ViewModels;


[ObservableObject]
[ObservableRecipient]
partial class MainWindowViewModel : IRecipient<ViewChanged>, IRecipient<StatusTextChanged>
{
    private static readonly BaseViewModel ridersVM = new RidersViewModel(new RiderRepository());
    //private static readonly BaseViewModel horsesVM = new HorsesViewModel(new HorsesRepository());


    [ObservableProperty]
    public BaseViewModel selectedViewModel = ridersVM;

    [ObservableProperty]
    private TopMenuViewModel topMenuViewModel = new TopMenuViewModel();

    [ObservableProperty]
    private string statusLabelText = string.Empty;

    public MainWindowViewModel()
    {
        Messenger = WeakReferenceMessenger.Default;
        Messenger.Register<ViewChanged>(this);
        Messenger.Register<StatusTextChanged>(this);
    }

    public void Receive(ViewChanged message)
    {
        switch (message.ViewName)
        {
            case "Activity":
                {
                    SelectedViewModel = new ActivityViewModel();
                    break;
                }
            case "AddEvent":
                {
                    SelectedViewModel = new AddEventViewModel();
                    break;
                }
            case "Horses":
                {
                    SelectedViewModel = new HorsesViewModel();
                    break;
                }
            case "Riders":
                {
                    SelectedViewModel = ridersVM;
                    break;
                }
            case "Holiday":
                {
                    SelectedViewModel = new HolidayViewModel();
                    break;
                }
            case "Save":
                {
                    SelectedViewModel = new SaveViewModel();
                    break;
                }
        }
    }

    public void Receive(StatusTextChanged message)
    {
        StatusLabelText = DateTime.Now.ToString() + ": " + message.StatusText;
    }
}
