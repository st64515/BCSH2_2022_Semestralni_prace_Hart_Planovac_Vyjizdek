using System.Windows.Controls;
using Planovac.Models;
using Planovac.ViewModels;

namespace Planovac.Views;

/// <summary>
/// Interakční logika pro RidersView.xaml
/// </summary>
public partial class RidersView : UserControl
{
    public RidersView()
    {
        //DataContext = new RidersViewModel(new RiderRepository());
        InitializeComponent();
    }
}
