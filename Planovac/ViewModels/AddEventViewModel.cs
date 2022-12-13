using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Planovac.ViewModels;

partial class AddEventViewModel : BaseViewModel
{
    private readonly IMessenger messenger = WeakReferenceMessenger.Default;

    public AddEventViewModel(RiderRepository riderRepository, HorseRepository horseRepository)
    {
        riders = riderRepository.Riders;
        horses = horseRepository.Horses;

        eventSelectedRider = riders.First();
        _comboBoxSelectedHorse = horses.First();
    }

    [ObservableProperty]
    private IEnumerable<Rider> riders;

    [ObservableProperty]
    private IEnumerable<Horse> horses;

    [ObservableProperty]
    private Horse? _listBoxSelectedHorse;

    [ObservableProperty]
    private Horse? _comboBoxSelectedHorse;


    [ObservableProperty]
    public DateTime eventDate = DateTime.Now;

    [ObservableProperty]
    public string eventStartTime = "10:00";

    [ObservableProperty]
    public string eventEndTime = "13:00";

    [ObservableProperty]
    public string eventDescription = "Zážitky";

    [ObservableProperty]
    public ObservableCollection<Horse> eventSelectedHorses = new();

    [ObservableProperty]
    private Rider? eventSelectedRider;

    [RelayCommand]
    public void AddSelectedHorse()
    {
        if (_comboBoxSelectedHorse != null)
        {
            eventSelectedHorses.Add(_comboBoxSelectedHorse);
        }
    }

    [RelayCommand]
    public void RemoveSelectedHorse()
    {
        if (_listBoxSelectedHorse != null)
        {
            eventSelectedHorses.Remove(_listBoxSelectedHorse);
        }
    }

    [RelayCommand]
    public void AddEvent()
    {

        //Create list of choosen horse names
        List<string> horseNames = new();
        foreach (Horse horse in eventSelectedHorses)
        {
            if (horse.Name is not null)
            {
                horseNames.Add(horse.Name);
            }
        }

        messenger.Send(new NewEventCreated(new Event
        {
            Date = eventDate,
            StartTime = eventStartTime,
            EndTime = eventEndTime,
            Description = eventDescription,
            MasterRider = eventSelectedRider.FullName,
            Horses = horseNames
        }));

        messenger.Send(new ViewChanged("Activity"));

        messenger.Send(new StatusTextChanged("Událost vytvořena"));
    }

}
