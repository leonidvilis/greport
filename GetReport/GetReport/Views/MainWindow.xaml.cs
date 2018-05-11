
using GetReport.BL;
using GetReport.Utils;
using System.Windows.Controls.Ribbon;

namespace GetReport.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        DefaultDialogService dialogService = new DefaultDialogService();
        SessionControl sesControl { get; set; }
        public DocsHierarchy.ReportOSR SelectedReport { get; set; }

        public static string path = System.IO.Directory.GetCurrentDirectory();
        //Свойства для активации/деактивации элементов управления.
        public bool NewSessionE;
        public bool OpenSessionE;
        public bool SaveSessionE;
        public bool SaveAsSessionE;
        public bool AddReportToListE;
        public bool DeleteReportFromListE;    

        public MainWindow()
        {
            InitializeComponent();
            sesControl = new SessionControl();
            SelectedReport = new DocsHierarchy.ReportOSR();
            Refresh();            
        }
        private void Refresh()
        {
            sessionReportList.ItemsSource = sesControl.session.ListOfReportOSR;            
        }


        #region Event Handlers
        private void RibbonButtonInfo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            dialogService.ShowMessage("Это тестовая версия программы для подготовки комплекта исполнительной документации.");
        }

        private void RibbonButtonNewSession_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sesControl.session.ListOfReportOSR.Count < 0)
            {
                sesControl.session.ListOfReportOSR.Clear();
            }
            else { dialogService.ShowMessage("Можно открыть лишь одну сессию за раз. Добавьте акт в комплект."); }
        }
        private void RibbonButtonOpen_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sesControl.session.ListOfReportOSR.Count == 0)
            {
                dialogService.OpenFileDialog();
                sesControl.OpenSession(dialogService.FilePath);
                Refresh();
            }
            else
            {
                dialogService.ShowMessage("Можно открыть лишь одну сессию за раз. Добавьте акт в комплект.");
            }
        }
        private void RibbonButtonSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sesControl.session.ListOfReportOSR.Count > 0)
            {
                dialogService.SaveFileDialog();
                sesControl.SaveSession(dialogService.FilePath);
            }
            else
            {                
                dialogService.ShowMessage("В сессии отсутствуют акты. Добавьте акты в комплект.");
            }
        }
        private void RibbonButtonAddReport_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            sesControl.AddReportToList();
            //Refresh();
        }
        private void RibbonButtonRemoveReport_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SelectedReport = (DocsHierarchy.ReportOSR)sessionReportList.SelectedItem;
            sesControl.RemoveReport(SelectedReport);
            //Refresh();
        }
        private void RibbonButtonPublishWord_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WordPublisherReportOSR.templatePath = path + @"\" + "ReportOSRTemplate.docx";
            WordPublisherReportOSR.GetPublishRulesReportOSR(path + @"\" + "PublishRulesReportOSR.txt");
            dialogService.OpenPath();
            WordPublisherReportOSR.GetPublish(sesControl.session.ListOfReportOSR, dialogService.FolderPath);
            //Refresh();
        }

        #endregion


    }
}
