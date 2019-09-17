using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleigan_3.Models
{
    class Status
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public DateTime StatusDate { get; set; }
        public bool available_YN { get; set; }
    }
}
