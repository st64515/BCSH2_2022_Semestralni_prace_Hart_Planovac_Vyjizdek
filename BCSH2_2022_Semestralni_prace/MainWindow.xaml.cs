using System.Windows;


namespace BCSH2_2022_Semestralni_prace;


public partial class MainWindow
{

    public MainWindow()
    {
        DataContext = new MainViewModel();
        InitializeComponent();
    }
    /*
                BCSH2_2022_Semestralni_prace.ViewModel.RiderViewModel riderViewModelObject =
           new BCSH2_2022_Semestralni_prace.ViewModel.RiderViewModel();
        riderViewModelObject.LoadRiders();

        RiderViewControl.DataContext = riderViewModelObject;
    */
    }

}