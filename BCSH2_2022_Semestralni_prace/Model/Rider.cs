using System.ComponentModel;

namespace BCSH2_2022_Semestralni_prace.Model
{
    public class Rider : INotifyPropertyChanged
    {
        private string name = "";
        private string surname = "";
        
        public bool HasLicense { get; set; } = false;
        public bool IsAdult { get; set; } = false;
        public string Description { get; set; } = "";

        public Rider(string nameOfNewRider)
        {
            name = nameOfNewRider;
        }

        public Rider(string name, string surname)
        {
            Surname = surname;
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string Surname
        {
            get { return surname; }

            set
            {
                if (surname != value)
                {
                    surname = value;
                    RaisePropertyChanged("Surname");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}