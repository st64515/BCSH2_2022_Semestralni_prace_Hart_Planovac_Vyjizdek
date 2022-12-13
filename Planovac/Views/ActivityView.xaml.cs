using Planovac.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Planovac.Views;

/// <summary>
/// Interakční logika pro ActivityView.xaml
/// </summary>
public partial class ActivityView : UserControl
{
    public ActivityView()
    {
        //DataContext = new ActivityViewModel();
        InitializeComponent();
    }
}
