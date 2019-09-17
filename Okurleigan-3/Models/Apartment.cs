using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okurleigan_3.Models;

namespace Okurleigan_3
{
    class Apartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public int RoomCount { get; set; }
        public ObservableCollection<Tenant> Tenants { get; set; }

        public Apartment()
        {
            this.Tenants = new ObservableCollection<Tenant>();
        }
        

    }
}
