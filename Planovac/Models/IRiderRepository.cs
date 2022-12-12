using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.Models
{
    public interface IRiderRepository
    {
        bool Add(Rider rider);
        bool Remove(Rider rider);
        bool Commit();
        IEnumerable<Rider> Riders { get; }
        void LoadFile(string filename);
    }
}
