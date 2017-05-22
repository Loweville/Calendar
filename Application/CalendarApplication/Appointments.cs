using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;

namespace Calendar
{
    class Appointments : List<IAppointment>, IAppointments
    {
        private Appointment app;
        private XmlDocument file = new XmlDocument();
        private string path = "StoredAppointments.xml";

        public Appointments()
        {
            file.Load(path);
        }

        public bool Load()
        {   // Loads appointments
            if (file.HasChildNodes)
            {
                object[] oVal = new object[4];
                XmlNode node = file.DocumentElement;
                // grabs each child from the file
                foreach (XmlNode nodeApps in node)
                {
                    for (int i = 0; i < nodeApps.ChildNodes.Count; i++)
                    {
                        XmlNode nodeInner = nodeApps.ChildNodes[i];
                        oVal[i] = nodeInner.InnerText;
                    }
                    // takes each object that has been loaded and creates 
                    // an appointment using those values
                    string d = (string)oVal[0];
                    DateTime s = Convert.ToDateTime(oVal[1]);
                    int l = Convert.ToInt32(oVal[2]);
                    int o = Convert.ToInt32(oVal[3]);
                    bool r = o != 0 ? true : false; 

                    app = new Appointment(s, l, d, r, o);
                    this.Add(app); // adds the appointment to the list of appointments
                    app = null;
                }
                
                if (this != null)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Save()
        {   // saves all appointments by rewriting all appointments 
            XmlNode node = file.DocumentElement;
            node.RemoveAll();

            if (this != null)
            {
                foreach (Appointment app in this)
                {   // grabs each element of the appointment and makes it easier to 
                    // implement later
                    string s = app.Start.ToString("dd/MM/yyyy HH:mm:ss");
                    string l = app.Length.ToString();
                    string d = app.DisplayableDescription;
                    string r = "1";
                    int id = node.ChildNodes.Count;

                    if (app.IsRecurring)
                    {
                        r = Convert.ToString(app.Occurances);
                    }

                    if (d == null || s == null || l == null || r == null)
                    {
                        return false;
                    }
                    // creates each element of the appointment and stores it 
                    // in xml format
                    XmlElement elementDescRef = file.CreateElement("Description");
                    XmlElement elementStartRef = file.CreateElement("Date");
                    XmlElement elementLenRef = file.CreateElement("Length");
                    XmlElement elementOccRef = file.CreateElement("Occurances");

                    elementDescRef.InnerText = d;
                    elementStartRef.InnerText = s;
                    elementLenRef.InnerText = l;
                    elementOccRef.InnerText = r;

                    XmlElement elementAppsRef = file.CreateElement("Appointment");
                    elementAppsRef.SetAttribute("id", Convert.ToString(id));
                    elementAppsRef.AppendChild(elementDescRef);
                    elementAppsRef.AppendChild(elementStartRef);
                    elementAppsRef.AppendChild(elementLenRef);
                    elementAppsRef.AppendChild(elementOccRef);

                    if (elementAppsRef.ChildNodes.Count != 4)
                    {
                        return false;
                    }

                    node.InsertAfter(elementAppsRef, node.LastChild);
                }

                file.Save(path);

                return true;
            }
            else
            {
                return true;
            }
        }

        public IEnumerable<IAppointment> GetAppointmentsOnDate(DateTime date)
        {   // gets appointments on date passed through
            foreach (Appointment appoint in this)
            {
                DateTime appointmentDate = appoint.Start;
                // checks the recurring appointments incase the selected 
                // date matches an occurance of the appointment
                for (int i = 0; i <= appoint.Occurances; i++)
                {
                    if (appoint.Start.Date.ToString("dd/MM/yyyy") == date.Date.ToString("dd/MM/yyyy") || 
                        appointmentDate.Date.ToString("dd/MM/yyyy") == date.Date.ToString("dd/MM/yyyy"))
                    {
                        yield return appoint;
                    }

                    string[] appSplit = appoint.DisplayableDescription.Split('-');
                    // This if statement allows the incrimentation of a recurring appointment happens
                    if (appSplit.Length == 3)
                    {
                        if (appSplit[2] == "Daily")
                        {
                            appointmentDate = appoint.Start.AddDays(i);
                        }
                        else if (appSplit[2] == "Weekly")
                        {
                            appointmentDate = appoint.Start.AddDays(i*7);
                        }
                        else if (appSplit[2] == "Monthly")
                        {
                            appointmentDate = appoint.Start.AddMonths(i);
                        }
                        else if (appSplit[2] == "Yearly")
                        {
                            appointmentDate = appoint.Start.AddYears(i);
                        }
                    }
                    
                }

                
            }
        }
    }
}