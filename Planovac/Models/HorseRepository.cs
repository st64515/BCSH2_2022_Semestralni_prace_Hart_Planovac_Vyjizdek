using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;

namespace Planovac.Models
{
    class HorseRepository : IHorseRepository
    {
        public IList<Horse> horses;
        private string actualFileName;

        public HorseRepository(string filename)
        {
            actualFileName = filename;
            var doc = XDocument.Load(actualFileName);
            horses = new ObservableCollection<Horse>((from c in doc.Descendants("Horse")
                                                      select new Horse
                                                      {
                                                          Name = GetValueOrDefault(c, "Name"),
                                                          Description = GetValueOrDefault(c, "Description"),
                                                      }).ToList());
        }

        #region ICustomerRepository Members

        public bool Add(Horse horse)
        {
            if (horses.IndexOf(horse) < 0)
            {
                horses.Add(horse);
                return true;
            }
            return false;
        }

        public bool Remove(Horse horse)
        {
            if (horses.IndexOf(horse) >= 0)
            {
                horses.Remove(horse);
                return true;
            }
            return false;
        }

        public bool Commit()
        {
            try
            {
                var doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
                var root = new XElement("Horses");
                foreach (Horse horse in horses)
                {
                    root.Add(new XElement("Horse",
                                          new XElement("Name", horse.Name),
                                          new XElement("Description", horse.Description)
                                 ));
                }
                doc.Add(root);
                doc.Save(actualFileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Horse> Horses
        {
            get { return horses; }
        }

        #endregion

        private static string GetValueOrDefault(XContainer el, string propertyName)
        {
            if (el.Element(propertyName) != null)
            {
                return el.Element(propertyName).Value;
            }
            else
            {
                return string.Empty;
            }
        }
        public void LoadFile(string filename)
        {
            actualFileName = filename;
            if (!System.IO.File.Exists(actualFileName))
            {
                horses = new List<Horse>();
                return;
            }
            var doc = XDocument.Load(filename);
            horses = new ObservableCollection<Horse>((from c in doc.Descendants("Horse")
                                                      select new Horse
                                                      {
                                                          Name = GetValueOrDefault(c, "Name"),
                                                          Description = GetValueOrDefault(c, "Description")
                                                      }).ToList());
        }
    }
}
