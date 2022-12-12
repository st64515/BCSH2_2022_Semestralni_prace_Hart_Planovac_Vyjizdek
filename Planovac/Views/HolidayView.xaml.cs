using Planovac.ViewModels;
using System.Windows.Controls;

namespace Planovac.Views;

/// <summary>
/// Interakční logika pro HolidayView.xaml
/// </summary>
public partial class HolidayView : UserControl
{
    public HolidayView()
    {
        DataContext = new HolidayViewModel();
        InitializeComponent();
    }
}
