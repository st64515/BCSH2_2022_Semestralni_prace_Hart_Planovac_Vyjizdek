using System.Windows.Controls;
using Planovac.ViewModels;

namespace Planovac.Views;

/// <summary>
/// Interakční logika pro TopMenuView.xaml
/// </summary>
public partial class TopMenuView : UserControl
{
    public TopMenuView()
    {
        DataContext = new TopMenuViewModel();
        InitializeComponent();
    }
}
