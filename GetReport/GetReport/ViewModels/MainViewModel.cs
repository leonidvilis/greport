using System.Collections.ObjectModel;
using System.Windows.Input;
using GetReport.Utils;
using PersonHierarchy;
using GetReport.BL;
using DocsHierarchy;

namespace GetReport.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        DefaultDialogService dialogService = new DefaultDialogService();

        SessionControl sesControl { get; set; }
        #region Propertyes
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<ReportOSRViewModel> _ReportList;
        public ObservableCollection<ReportOSRViewModel> ReportList
        {
            get
            {
                if (sesControl.getSesReportList() != null)
                {
                    foreach (ReportOSR item in sesControl.getSesReportList())
                    {
                        _ReportList.Add(new ReportOSRViewModel(item));
                    }
                }                
                return _ReportList;
            }
            set
            {
                foreach (var item in value)
                {
                    ObservableCollection<ReportOSR> list = new ObservableCollection<ReportOSR>();
                    ReportOSR report = new ReportOSR();                    
                        report.TypeOfReport                          = ReportTypes.AOSR;
                        report.NameAndAddressOfObject                = item.NameAndAddressOfObject;
                        report.RequisitesOfConsumer                  = item.RequisitesOfConsumer;
                        report.RequisitesOfPrimeContractor           = item.RequisitesOfPrimeContractor;
                        report.RequisitesOfProjectDeveloper          = item.RequisitesOfProjectDeveloper;
                        report.RequisitesOfBuilder                   = item.RequisitesOfBuilder;
                        report.NumberOfReport                        = item.NumberOfReport;
                        report.DateOfPreparationOfReport             = item.DateOfPreparationOfReport;
                        report.DelegateOfConsumer                    = item.DelegateOfConsumer;
                        report.DelegateOfPrimeContractor             = item.DelegateOfPrimeContractor;
                        report.DelegateOfBuildControlPrimeContractor = item.DelegateOfBuildControlPrimeContractor;
                        report.DelegateOfProjectDeveloper            = item.DelegateOfProjectDeveloper;
                        report.DelegateOfBuilder                     = item.DelegateOfBuilder;
                        report.DelegateOfOtherCompany                = item.DelegateOfOtherCompany;
                        report.DelegateOfOtherCompany2               = item.DelegateOfOtherCompany2;
                        report.DelegateOfOtherCompany3               = item.DelegateOfOtherCompany3;
                        report.Builder                               = item.Builder;
                        report.WorkName                              = item.WorkName;
                        report.ProjectTheWorkIncluded                = item.ProjectTheWorkIncluded;
                        report.TheListOfMaterial                     = item.TheListOfMaterial;
                        report.TheListOfQuantityConsistDocs          = item.TheListOfQuantityConsistDocs;
                        report.TheDateOfWorkStart                    = item.TheDateOfWorkStart;
                        report.TheDateOfWorkEnding                   = item.TheDateOfWorkEnding;
                        report.TheListOfDocumentConsists             = item.TheListOfDocumentConsists;
                        report.TheNextWorkIsAccepted                 = item.TheNextWorkIsAccepted;
                        report.Annexes                               = item.Annexes;
                    list.Add(report);
                }
                _ReportList = value;
                OnPropertyChanged("ReportList");
            }
        }

        private ObservableCollection<Member> _DelegateList;
        public ObservableCollection<Member> DelegateList
        {
            get { return _DelegateList; }
            set { _DelegateList = value; OnPropertyChanged("DelegateList"); }
        }

        private ReportOSRViewModel _SelectedReport;
        public ReportOSRViewModel SelectedReport
        {
            get { return _SelectedReport; }
            set { _SelectedReport = value; OnPropertyChanged("SelectedReport"); }
        }

        //Свойства для активации/деактивации элементов управления.
        private bool _NewSessionE;
        public bool NewSessionE { get { return _NewSessionE; } set { _NewSessionE = value; OnPropertyChanged("NewSessionE"); } }

        private bool _OpenSessionE;
        public bool OpenSessionE { get { return _OpenSessionE; } set { _OpenSessionE = value; OnPropertyChanged("OpenSessionE"); } }

        private bool _SaveSessionE;
        public bool SaveSessionE { get { return _SaveSessionE; } set { _SaveSessionE = value; OnPropertyChanged("SaveSessionE"); } }

        private bool _SaveAsSessionE;
        public bool SaveAsSessionE { get { return _SaveAsSessionE; } set { _SaveAsSessionE = value; OnPropertyChanged("SaveAsSessionE"); } }

        private bool _AddReportToListE;
        public bool AddReportToListE { get { return _AddReportToListE; } set { _AddReportToListE = value; OnPropertyChanged("AddReportToListE"); } }

        private bool _DeleteReportFromListE;
        public bool DeleteReportFromListE { get { return _DeleteReportFromListE; } set { _DeleteReportFromListE = value; OnPropertyChanged("DeleteReportFromListE"); } }        
        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Parameters

        /// <summary>
        /// Title of the application, as displayed in the top bar of the window
        /// </summary>
        public string Title
        {
            get { return "GetReport"; }
        }
        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Constructors
        public MainViewModel()
        {
            // DialogService is used to handle dialogs
            sesControl = new SessionControl();
            ReportList = new ObservableCollection<ReportOSRViewModel>();
            DelegateList = new ObservableCollection<Member>();
            NewSessionE = true;
            OpenSessionE = true;
            SaveSessionE = false;
            SaveAsSessionE = false;
            AddReportToListE = false;
            DeleteReportFromListE = false;
        }

        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Methods

        #endregion
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Commands
        public RelayCommand<object> SampleCmdWithArgument { get { return new RelayCommand<object>(OnSampleCmdWithArgument); } }

        public ICommand SaveAsCmd { get { return new RelayCommand(OnSaveAsTest); } }
        public ICommand SaveCmd { get { return new RelayCommand(OnSaveTest); } }
        public ICommand NewCmd { get { return new RelayCommand(OnNewTest); } }
        public ICommand OpenCmd { get { return new RelayCommand(OnOpenTest); } }
        public ICommand ShowAboutDialogCmd { get { return new RelayCommand(OnShowAboutDialog); } }
        public ICommand ShowDelegateListDialogCmd { get { return new RelayCommand(OnShowDelegateListDialog); } }
        public ICommand ExitCmd { get { return new RelayCommand(OnExitApp); } }
        public ICommand AddReportToList { get { return new RelayCommand(OnAddReportToList); } }
        public ICommand DeleteReportFromList { get { return new RelayCommand(OnDeleteReportFromList); } }

        private void OnSampleCmdWithArgument(object obj)
        {
            // TODO
        }

        private string fileName;
        private void OnSaveAsTest()
        {
            bool? success = dialogService.SaveFileDialog("C:\\", "File (.xml)|*.xml", "Save As", true, false, true);
            if (success == true)
            {
                // Do something
                fileName = dialogService.FilePath;
                sesControl.SaveSession(fileName);
            }
        }
        private void OnSaveTest()
        {
            if (fileName == null)
            {
                OnSaveAsTest();
            }
            else
            {
                //fileService.Save(fileName, ReportList);
                sesControl.SaveSession(fileName);
            }
            
            // TODO
        }
        private void OnNewTest()
        {
            //if (ReportList == null)
            //{
                sesControl.sesControlListOfReportClear();
                NewSessionE = false;
                OpenSessionE = false;
                SaveSessionE = true;
                SaveAsSessionE = true;
                AddReportToListE = true;
                DeleteReportFromListE = true;
            //}
            //else
            //{
            //    dialogService.ShowMessage("Object already maked");
            //}
            // TODO
        }
        private void OnOpenTest()
        {

            bool? success = dialogService.OpenFileDialog("C:\\", "Open", "Sample (.xml)|*.xml", true, false);
            if (success == true)
            {
                fileName = dialogService.FilePath;
                //ReportList = fileService.Open(fileName);
                sesControl.OpenSession(fileName);
            }
        }
        private void OnShowAboutDialog()
        {
            dialogService.ShowMessage("Это тестовая версия программы для подготовки исполнительной документации по форме РД 11-02-06.");
        }
        private void OnShowDelegateListDialog()
        {
            
        }
        private void OnExitApp()
        {
            //System.Windows.Application.Current.MainWindow.Close();
            GetReport.App.Current.MainWindow.Close();
        }
        private void OnAddReportToList()
        {
            sesControl.AddReportToList();
            //ReportList.Add(new ReportOSRViewModel());
            DeleteReportFromListE = true;
        }

        private void OnDeleteReportFromList()
        {
            if (SelectedReport != null)            
            ReportList.Remove(SelectedReport);
            if (ReportList.Count == 0)
                DeleteReportFromListE = false;
        }
        #endregion

        #region Events
        
        #endregion
    }
}
