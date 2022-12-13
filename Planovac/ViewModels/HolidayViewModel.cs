using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System;
using System.Collections.Generic;

namespace Planovac.ViewModels;

partial class HolidayViewModel : BaseViewModel
{
    private readonly IMessenger messenger = WeakReferenceMessenger.Default;

    [ObservableProperty]
    public DateTime eventDate = DateTime.Now;

    [ObservableProperty]
    public string eventDescription = "Závody";

    [RelayCommand]
    public void AddEvent()
    {

        messenger.Send(new NewEventCreated(new Event
        {
            Date = eventDate,
            Description = eventDescription,
        }));

        messenger.Send(new ViewChanged("Activity"));

        messenger.Send(new StatusTextChanged("Volno vytvořeno"));
    }

}


