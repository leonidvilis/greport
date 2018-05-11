using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PersonHierarchy;
using DocsHierarchy;
using System.Collections.ObjectModel;

namespace GetReport.BL
{
    public sealed class SessionControl
    {
        public Session session { get; set; }
        static XmlFileService<ReportOSR> fileService { get; set; }

        public SessionControl()
        {
            session = new Session();
            fileService = new XmlFileService<ReportOSR>();
        }
        #region Methods
        public static ObservableCollection<Member> LoadListOfMember()
        {
            ObservableCollection<Member> list = new ObservableCollection<Member>();
            try
            {
                using(StreamReader sr = new StreamReader("ListOfMember.txt", Encoding.Default))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] arr = line.Split(',');
                        list.Add(new Member(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]));
                    }
                }
                
            }
            catch(FileLoadException)
            {
                throw;
            }
            return list;
        }

        public void OpenSession(string filename)
        {
            session.ListOfReportOSR = fileService.Open(filename);
        }

        public void SaveSession(string filename)
        {
            fileService.Save(filename, session.ListOfReportOSR);
        }
        public void AddReportToList()
        {
            session.ListOfReportOSR.Add(new ReportOSR());
        }
        public void RemoveReport(ReportOSR rep)
        {
            session.ListOfReportOSR.Remove(rep);
        }
        public ObservableCollection<ReportOSR> getSesReportList()
        {
            return session.ListOfReportOSR;
        }
        public void setSesReportList(ObservableCollection<ReportOSR> list)
        {
            session.ListOfReportOSR = list;
        }                
        public void sesControlListOfReportClear()
        {
            session.ListOfReportOSR.Clear();
        }
        #endregion
    }
}