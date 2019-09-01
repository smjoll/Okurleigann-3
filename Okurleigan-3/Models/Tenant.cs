using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class Tenant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
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

    }
}
