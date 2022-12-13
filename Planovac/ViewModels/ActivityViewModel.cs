using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Planovac.ViewModels
{
    [ObservableRecipient]
    partial class ActivityViewModel : BaseViewModel, IRecipient<SaveRequest>
    {
        private readonly IEventRepository _eventRepository;

        public IEnumerable<Event> Events => _eventRepository.Events;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand),nameof(ArchiveCommand))]
        private Event? _selectedEvent;

        [ObservableProperty]
        private string? _selectedHorse;

        public ActivityViewModel(EventRepository eventRepository)
        {
            _eventRepository = eventRepository ??
                              throw new ArgumentNullException(nameof(eventRepository));

            Messenger = WeakReferenceMessenger.Default;
            Messenger.Register<SaveRequest>(this);


        }

        public void Receive(SaveRequest message)
        {
            if (_eventRepository.Commit())
            {
                Messenger.Send(new StatusTextChanged("Uloženo"));
            }
        }

        [RelayCommand(CanExecute = "HasSelectedEvent")]
        private void Remove()
        {
            if (SelectedEvent != null)
            {
                _eventRepository.Remove(SelectedEvent);
                Messenger.Send(new StatusTextChanged("Akce byla odstraněna"));
                SelectedEvent = null;
                OnPropertyChanged(nameof(Events));
            }
        }

        [RelayCommand(CanExecute = "HasSelectedEvent")]
        public void Archive()
        {
            if (SelectedEvent != null)
            {
                Messenger.Send(new EventArchived(SelectedEvent));
                Messenger.Send(new StatusTextChanged("Akce přesunuta do archivu"));
                _eventRepository.Remove(SelectedEvent);
                SelectedEvent = null;
                OnPropertyChanged(nameof(Events));
            }
        }

        [RelayCommand]
        private void RemoveHorse()
        {
            if (SelectedHorse != null)
            {
                SelectedEvent.Horses.Remove(SelectedHorse);
                SelectedHorse = null;
                OnPropertyChanged(nameof(Events));
            }
        }

        private bool HasSelectedEvent() => SelectedEvent != null;
    }
}
