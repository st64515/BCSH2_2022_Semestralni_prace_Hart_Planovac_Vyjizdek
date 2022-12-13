using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planovac.Models
{
    public interface IHorseRepository
    {
        bool Add(Horse horse);
        bool Remove(Horse horse);
        bool Commit();
        IEnumerable<Horse> Horses { get; }
        void LoadFile(string filename);
    }
}
