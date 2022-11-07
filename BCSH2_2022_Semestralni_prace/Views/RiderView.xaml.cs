using BCSH2_2022_Semestralni_prace.Model;
using BCSH2_2022_Semestralni_prace.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BCSH2_2022_Semestralni_prace.Views
{
    /// <summary>
    /// Interakční logika pro ControlView.xaml
    /// </summary>
    public partial class RiderView : UserControl
    {
        RiderViewModel riderViewModel = new();
        List<Rider> riders = new();
        
        public RiderView()
        {
            InitializeComponent();


            riderViewModel.LoadRiders();
            refreshItemsSource();

        }
        private void refreshItemsSource()
        {
            foreach (Rider r in riderViewModel.Riders)
            {
                riders.Add(r);
            }
            listBoxRiders.ItemsSource = riders;
        }

        private void LstRiders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBoxName.Text = (listBoxRiders.SelectedItem as Rider)?.Name;
            textBoxSurname.Text = (listBoxRiders.SelectedItem as Rider)?.Surname;
        }

        private void BtnAddRider_Click(object sender, RoutedEventArgs e)
        {
            riderViewModel.AddRider(textBoxNameOfNewRider.Text);
            refreshItemsSource();
            
        }
    }
}
