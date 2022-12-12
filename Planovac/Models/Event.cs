using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.Models
{
    class Event
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; } = "";
        public List<Horse>? Horses { get; set; }
        public Rider? MasterRider { get; set; }
    }
}
