using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.ViewModels
{
    [ObservableRecipient]
    partial class ArchiveViewModel : BaseViewModel, IRecipient<SaveRequest>, IRecipient<EventArchived>
    {

        private readonly IEventRepository _eventRepository;

        public IEnumerable<Event> Events => _eventRepository.Events;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        private Event? _selectedEvent;


        public ArchiveViewModel(EventRepository eventRepository)
        {
            _eventRepository = eventRepository ??
                              throw new ArgumentNullException(nameof(eventRepository));

            Messenger = WeakReferenceMessenger.Default;
            Messenger.Register<SaveRequest>(this);
            Messenger.Register<EventArchived>(this);
        }

        public void Receive(EventArchived message)
        {
            if (message.archivedEvent != null)
            {
                _eventRepository.Add(message.archivedEvent);
                OnPropertyChanged(nameof(Events));
            }
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
                SelectedEvent = null;
                OnPropertyChanged(nameof(Events));
                Messenger.Send(new StatusTextChanged("Akce byla odstraněna z archivu"));
            }
        }

        private bool HasSelectedEvent() => SelectedEvent != null;

    }
}
