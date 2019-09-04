using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class SharedContext
    {
        public static ApartmentDbContext dbContext = new ApartmentDbContext();

        public static ObservableCollection<Tenant> Tenants = new ObservableCollection<Tenant>();
        public static ObservableCollection<Apartment> Apartments = new ObservableCollection<Apartment>();
        public static Tenant selectedTenant = new Tenant();
    }
}
