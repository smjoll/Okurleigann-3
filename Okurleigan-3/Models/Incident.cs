using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class Incident
    {
        public int Id { get; set; }
        public string IncidentInfo { get; set; }
        public int ApartmentId { get; set; }
    }
}
