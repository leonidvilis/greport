using GetReport.BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GetReport.Views
{
    /// <summary>
    /// Логика взаимодействия для ReportOSRView.xaml
    /// </summary>
    public partial class ReportOSRView : UserControl
    {
        DocsHierarchy.ReportOSR report = new DocsHierarchy.ReportOSR();
        ObservableCollection<PersonHierarchy.Member> list = new ObservableCollection<PersonHierarchy.Member>();
        public ReportOSRView()
        {
            list = SessionControl.LoadListOfMember();
            InitializeComponent();
            delegateOfConsumer.ItemsSource = list;
            delegateOfConsumer.SelectedItem = report.DelegateOfConsumer;
            delegateOfPrimeContractor.ItemsSource = list;
            delegateOfPrimeContractor.SelectedItem = report.DelegateOfConsumer;
            delegateOfBuildControlPrimeContractor.ItemsSource = list;
            delegateOfBuildControlPrimeContractor.SelectedItem = report.DelegateOfConsumer;
            delegateOfProjectDeveloper.ItemsSource = list;
            delegateOfProjectDeveloper.SelectedItem = report.DelegateOfConsumer;
            delegateOfBuilder.ItemsSource = list;
            delegateOfBuilder.SelectedItem = report.DelegateOfConsumer;
            delegateOfOtherCompany.ItemsSource = list;
            delegateOfOtherCompany.SelectedItem = report.DelegateOfConsumer;
            delegateOfOtherCompany2.ItemsSource = list;
            delegateOfOtherCompany2.SelectedItem = report.DelegateOfConsumer;
            delegateOfOtherCompany3.ItemsSource = list;
            delegateOfOtherCompany3.SelectedItem = report.DelegateOfConsumer;
        }
    }
}
