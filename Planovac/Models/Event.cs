using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.Models
{
    public class Event
    {
        public DateTime Date { get; set; }
        public string StartTime { get; set; } = "";
        public string EndTime { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string>? Horses { get; set; }
        public string? MasterRider { get; set; }
        public string HorsesString
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                if (Horses is not null )
                {
                    foreach (string hor in Horses)
                    {
                        stringBuilder.Append(hor);
                        if (hor != Horses.Last())
                        {
                            stringBuilder.Append(", ");
                        }
                    }
                }
                return stringBuilder.ToString();
            }
        }
    }
}
