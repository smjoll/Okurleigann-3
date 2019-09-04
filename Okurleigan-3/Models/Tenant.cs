using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class Tenant : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;            
            }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("Fullname");
            }
        }


        private string _lastName;
        public string Lastname
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyPropertyChanged("Fullname");
            }
        }

        public string Fullname
        {

            get
            {
                return FirstName + " " + Lastname;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int ApartmentId { get; set; }

        public ObservableCollection<Apartment> Apartments { get; set; }

        public Tenant()
        {
            DateOfBirth = DateTime.Now;
        }

        private void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

                

    }
}
