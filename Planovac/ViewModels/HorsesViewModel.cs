using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Planovac.Models;
using System.Collections.Generic;
using System;

namespace Planovac.ViewModels;

[ObservableRecipient]
partial class HorsesViewModel : BaseViewModel, IRecipient<SaveRequest>
{
    private readonly IHorseRepository _horseRepository;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
    private Horse? _selectedHorse;

    public IEnumerable<Horse> Horses => _horseRepository.Horses;


    public HorsesViewModel(IHorseRepository horseRepository)
    {
        _horseRepository = horseRepository ??
                              throw new ArgumentNullException(nameof(horseRepository));
        Messenger = WeakReferenceMessenger.Default;
        Messenger.Register<SaveRequest>(this);
    }

    public void Receive(SaveRequest message)
    {
        if (_horseRepository.Commit())
        {
            Messenger.Send(new StatusTextChanged("Uloženo"));
        }
    }

    [RelayCommand]
    private void Add()
    {
        var horse = new Horse();
        _horseRepository.Add(horse);
        SelectedHorse = horse;
        OnPropertyChanged(nameof(Horses));
    }

    [RelayCommand(CanExecute = "HasSelectedHorse")]
    private void Remove()
    {
        if (SelectedHorse != null)
        {
            _horseRepository.Remove(SelectedHorse);
            SelectedHorse = null;
            OnPropertyChanged(nameof(Horses));
        }
    }

    private bool HasSelectedHorse() => SelectedHorse != null;
}
