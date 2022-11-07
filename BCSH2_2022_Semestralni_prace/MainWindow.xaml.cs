using System.Windows;

namespace BCSH2_2022_Semestralni_prace
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RiderViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            BCSH2_2022_Semestralni_prace.ViewModel.RiderViewModel riderViewModelObject =
               new BCSH2_2022_Semestralni_prace.ViewModel.RiderViewModel();
            riderViewModelObject.LoadRiders();

            RiderViewControl.DataContext = riderViewModelObject;
        }
    }
}