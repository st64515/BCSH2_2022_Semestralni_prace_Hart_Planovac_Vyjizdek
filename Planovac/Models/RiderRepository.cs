using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;

namespace Planovac.Models
{
    class RiderRepository : IRiderRepository
    {
        public IList<Rider> riders;
        private string actualFileName;

        public RiderRepository(string filename)
        {
            actualFileName = filename;
            var doc = XDocument.Load(actualFileName);
            riders = new ObservableCollection<Rider>((from c in doc.Descendants("Rider")
                                                      select new Rider
                                                      {
                                                          FirstName = GetValueOrDefault(c, "FirstName"),
                                                          LastName = GetValueOrDefault(c, "LastName"),
                                                          HasLicense = GetValueOrDefault(c, "HasLicense"),
                                                          IsAdult = GetValueOrDefault(c, "IsAdult"),
                                                          Description = GetValueOrDefault(c, "Description")
                                                      }).ToList());
        }

        #region ICustomerRepository Members

        public bool Add(Rider rider)
        {
            if (riders.IndexOf(rider) < 0)
            {
                riders.Add(rider);
                return true;
            }
            return false;
        }

        public bool Remove(Rider rider)
        {
            if (riders.IndexOf(rider) >= 0)
            {
                riders.Remove(rider);
                return true;
            }
            return false;
        }

        public bool Commit()
        {
            try
            {
                var doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
                var root = new XElement("Riders");
                foreach (Rider rider in riders)
                {
                    root.Add(new XElement("Rider",
                                          new XElement("FirstName", rider.FirstName),
                                          new XElement("LastName", rider.LastName),
                                          new XElement("HasLicense", rider.HasLicense),
                                          new XElement("IsAdult", rider.IsAdult),
                                          new XElement("Description", rider.Description)
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
        public IEnumerable<Rider> Riders
        {
            get { return riders; }
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
                riders = new List<Rider>();
                return;
            }
            var doc = XDocument.Load(filename);
            riders = new ObservableCollection<Rider>((from c in doc.Descendants("Rider")
                                                      select new Rider
                                                      {
                                                          FirstName = GetValueOrDefault(c, "FirstName"),
                                                          LastName = GetValueOrDefault(c, "LastName"),
                                                          HasLicense = GetValueOrDefault(c, "HasLicense"),
                                                          IsAdult = GetValueOrDefault(c, "IsAdult"),
                                                          Description = GetValueOrDefault(c, "Description")
                                                      }).ToList());
        }
    }
}
