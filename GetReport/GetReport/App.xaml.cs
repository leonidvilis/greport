using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.ComponentModel;
using GetReport.ViewModels;
using GetReport.Views;

namespace GetReport
{
    public partial class App : Application
    {
        private static MainWindow app;

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            // For catching Global uncaught exception
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionOccured);

            
            app = new MainWindow();
            var context = new MainViewModel();
            app.DataContext = context;
            app.Show();

            if (e.Args.Length == 1) //make sure an argument is passed
            {               
                FileInfo file = new FileInfo(e.Args[0]);
                if (file.Exists) //make sure it's actually a file
                {
                    // Here, add you own code
                    //((MainViewModel)app.DataContext).OpenFile(file.FullName);
                }
            }
        }

        static void UnhandledExceptionOccured(object sender, UnhandledExceptionEventArgs args)
        {          

            Exception e = (Exception)args.ExceptionObject;
        }
    }
}
