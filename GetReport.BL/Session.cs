using DocsHierarchy;
using PersonHierarchy;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GetReport.BL
{
    public class Session
    {
        //public delegate bool ListOfReportOSRChanged();
        //public event ListOfReportOSRChanged Changed;
        public ObservableCollection<ReportOSR> ListOfReportOSR { get; set; }

        internal Session()
        {
            ListOfReportOSR = new ObservableCollection<ReportOSR>();            
        }
    }
}