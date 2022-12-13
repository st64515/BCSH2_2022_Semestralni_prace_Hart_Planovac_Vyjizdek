using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml.Linq;

namespace Planovac.Models
{
    class EventRepository : IEventRepository
    {
        public IList<Event> _events;
        private string actualFileName;

        public EventRepository(string filename)
        {
            actualFileName = filename;
            _events = new ObservableCollection<Event>();


            var doc = XDocument.Load(actualFileName);
            if (doc.Element("Events") is not null)
            {
                XElement root = doc.Element("Events");
                foreach (XElement Event in root.Elements("Event"))
                {
                    _events.Add(new Event
                    {
                        Date = GetDateTimeValueOrDefault(Event, "Date"),
                        StartTime = GetStringValueOrDefault(Event, "StartTime"),
                        EndTime = GetStringValueOrDefault(Event, "EndTime"),
                        Description = GetStringValueOrDefault(Event, "Description"),
                        Horses = GetListValueOrDefault(Event, "Horses", "Horse"),
                        MasterRider = GetStringValueOrDefault(Event, "MasterRider")
                    });
                }
            }
        }

        #region ICustomerRepository Members

        public bool Add(Event _event)
        {
            if (_events.IndexOf(_event) < 0)
            {
                _events.Add(_event);
                return true;
            }
            return false;
        }

        public bool Remove(Event _event)
        {
            if (_events.IndexOf(_event) >= 0)
            {
                _events.Remove(_event);
                return true;
            }
            return false;
        }

        public bool Commit()
        {
            try
            {
                var doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
                var root = new XElement("Events");
                doc.Add(root);
                foreach (Event _event in _events)
                {
                    var xEvent = new XElement("Event");
                    xEvent.Add(new XElement("Date", _event.Date));
                    xEvent.Add(new XElement("StartTime", _event.StartTime));
                    xEvent.Add(new XElement("EndTime", _event.EndTime));
                    xEvent.Add(new XElement("Description", _event.Description));

                    var xHorses = new XElement("Horses");
                    if (_event.Horses is not null)
                    {
                        foreach (string horseName in _event.Horses)
                        {
                            xHorses.Add(new XElement("Horse", horseName));
                        }
                    }
                    xEvent.Add(xHorses);

                    xEvent.Add(new XElement("MasterRider", _event.MasterRider));
                    root.Add(xEvent);
                }
                doc.Save(actualFileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Event> Events
        {
            get { return _events; }
        }

        #endregion

        private static string GetStringValueOrDefault(XContainer el, string propertyName)
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

        private static DateTime GetDateTimeValueOrDefault(XContainer el, string propertyName)
        {
            if (el.Element(propertyName) != null)
            {
                return DateTime.Parse(el.Element(propertyName).Value);
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        private static List<string> GetListValueOrDefault(XElement el, string arrayName, string elementName)
        {
            var _horses = new List<string>();

            XElement horses = el.Element(arrayName);
            foreach (XElement horse in horses.Elements(elementName))
            {
                _horses.Add(horse.Value);
            }
            return _horses;
        }

        public void LoadFile(string filename)
        {

            actualFileName = filename;
            if (!System.IO.File.Exists(actualFileName))
            {
                _events = new List<Event>();
                return;
            }

            var doc = XDocument.Load(filename);
            XElement root = doc.Element("Events");
            foreach (XElement Event in root.Elements("Event"))
            {
                _events.Add(new Event
                {
                    Date = GetDateTimeValueOrDefault(Event, "Date"),
                    StartTime = GetStringValueOrDefault(Event, "StartTime"),
                    EndTime = GetStringValueOrDefault(Event, "EndTime"),
                    Description = GetStringValueOrDefault(Event, "Description"),
                    Horses = GetListValueOrDefault(Event, "Horses", "Horse"),
                    MasterRider = GetStringValueOrDefault(Event, "MasterRider")
                });
            }

        }

        public string ToFormattedString()
        {
            StringBuilder str = new StringBuilder();

            foreach (Event e in _events)
            {
                str.Append(Environment.NewLine);
                str.AppendLine("------------");
                str.AppendLine($"{e.Description}");
                str.AppendLine(e.Date.ToString("dd.MM.yyyy"));
                if (e.MasterRider != "")
                {
                    str.AppendLine($"Pojede {e.MasterRider}");
                }
                if (e.StartTime!= "")
                {
                str.AppendLine($"v {e.StartTime} hodin");

                }

            }
            str.AppendLine("------------");
            str.Append(Environment.NewLine);

            return str.ToString();
        }


    }
}

