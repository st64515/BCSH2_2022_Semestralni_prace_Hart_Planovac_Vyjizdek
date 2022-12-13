using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Planovac.ViewModels;


[ObservableObject]
[ObservableRecipient]
partial class MainWindowViewModel : IRecipient<ViewChanged>, IRecipient<StatusTextChanged>, IRecipient<NewEventCreated>, IRecipient<PostToTelegramRequest>
{
    static TelegramBotClient Bot = new TelegramBotClient("5604187671:AAEAFhuLb0c9VZ6dm__bzp8kBpaF_CR5iHc");

    private static readonly RiderRepository riders= new("Riders.xml");
    private static readonly HorseRepository horses= new("Horses.xml");
    private static readonly EventRepository events= new("Events.xml");
    private static readonly EventRepository eventsArchive= new("EventsArchive.xml");


    private static readonly RidersViewModel ridersVM = new(riders);
    private static readonly HorsesViewModel horsesVM = new(horses);
    private static readonly AddEventViewModel addEventVM = new(riders, horses);
    private static readonly ActivityViewModel activityVM = new(events);
    private static readonly ArchiveViewModel archiveVM = new(eventsArchive);
    private static readonly HolidayViewModel holidayVM = new();
    

    [ObservableProperty]
    public BaseViewModel selectedViewModel = activityVM;

    [ObservableProperty]
    private TopMenuViewModel topMenuViewModel = new TopMenuViewModel();

    [ObservableProperty]
    private string statusLabelText = string.Empty;

    public MainWindowViewModel()
    {
        Messenger = WeakReferenceMessenger.Default;
        Messenger.Register<ViewChanged>(this);
        Messenger.Register<StatusTextChanged>(this);
        Messenger.Register<NewEventCreated>(this);
        Messenger.Register<PostToTelegramRequest>(this);
    }

    public void Receive(ViewChanged message)
    {
        switch (message.ViewName)
        {
            case "Activity":
                {
                    SelectedViewModel = activityVM;
                    break;
                }
            case "AddEvent":
                {
                    SelectedViewModel = addEventVM;
                    break;
                }
            case "Horses":
                {
                    SelectedViewModel = horsesVM;
                    break;
                }
            case "Riders":
                {
                    SelectedViewModel = ridersVM;
                    break;
                }
            case "Holiday":
                {
                    SelectedViewModel = holidayVM;
                    break;
                }
            case "Archive":
                {
                    SelectedViewModel = archiveVM;
                    break;
                }
        }
    }

    public void Receive(StatusTextChanged message)
    {
        StatusLabelText = DateTime.Now.ToString() + ": " + message.StatusText;
    }

    public void Receive(NewEventCreated message)
    {
        events.Add(message.newEvent);
    }

    public void Receive(PostToTelegramRequest message)
    {
        var mojeId = new ChatId(5755763311);

        Bot.SendTextMessageAsync(mojeId, events.ToFormattedString());
        Messenger.Send(new StatusTextChanged("Odesláno"));
    }
}
