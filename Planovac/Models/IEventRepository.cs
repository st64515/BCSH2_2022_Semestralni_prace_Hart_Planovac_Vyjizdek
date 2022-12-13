using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.Models
{
    public interface IEventRepository
    {
        bool Add(Event e);
        bool Remove(Event e);
        bool Commit();
        IEnumerable<Event> Events { get; }
        void LoadFile(string filename);
    }
}
