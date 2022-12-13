using CommunityToolkit.Mvvm.ComponentModel;
using Planovac.Models;
using System.Collections.Generic;
using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace Planovac.ViewModels;

[ObservableRecipient]
public partial class RidersViewModel : BaseViewModel, IRecipient<SaveRequest>
{
    private readonly IRiderRepository _riderRepository;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
    private Rider? _selectedRider;

    public IEnumerable<Rider> Riders => _riderRepository.Riders;


    public RidersViewModel(IRiderRepository riderRepository)
    {
        _riderRepository = riderRepository ??
                              throw new ArgumentNullException(nameof(riderRepository));
        Messenger = WeakReferenceMessenger.Default;
        Messenger.Register<SaveRequest>(this);
    }

    public void Receive(SaveRequest message)
    {
        if (_riderRepository.Commit())
        {
            Messenger.Send(new StatusTextChanged("Uloženo"));
        }
    }

    [RelayCommand]
    private void Add()
    {
        var rider = new Rider();
        _riderRepository.Add(rider);
        SelectedRider = rider;
        OnPropertyChanged("Riders");
    }

    [RelayCommand(CanExecute = "HasSelectedRider")]
    private void Remove()
    {
        if (SelectedRider != null)
        {
            _riderRepository.Remove(SelectedRider);
            SelectedRider = null;
            OnPropertyChanged("Riders");
        }
    }

    private bool HasSelectedRider() => SelectedRider != null;
    
}
