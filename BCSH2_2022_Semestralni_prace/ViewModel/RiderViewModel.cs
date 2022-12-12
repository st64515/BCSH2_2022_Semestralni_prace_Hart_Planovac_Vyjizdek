using BCSH2_2022_Semestralni_prace.Model;
//using prepinaniViews.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace BCSH2_2022_Semestralni_prace.ViewModel
{

    public class RiderViewModel //: BaseViewModel
    {

        public ObservableCollection<Rider> Riders
        {
            get;
            set;
        } = new();

        public void AddRider(string nameOfNewRider)
        {
            string s = nameOfNewRider;
            Riders.Add(new Rider(s));
        }

        public void LoadRiders()
        {
            ObservableCollection<Rider> riders = new()
            {
                new Rider ("Lída",  "Kolářová") ,
                new Rider ("Terka",  "Laslová" ),
                new Rider ( "Mája",  "Kovářová" )
            };

            Riders = riders;
        }
    }
}