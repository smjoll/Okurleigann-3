using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class Rental
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public int TenantId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
    }
}
