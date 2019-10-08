using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.UI.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ppedv.LibertyBooks.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Backgroundworker_Aufgabe;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += Backgroundworker_ReportProgress;
            // Variante 1)
            // this.DataContext = new MainViewModel(new Logic.Core(new EFRepository(new EFContext())));
        }

        private void Backgroundworker_ReportProgress(object sender, ProgressChangedEventArgs e)
        {
            // Zeigt den Progress in der Oberfläche an
            // ---> Wird auf dem UI-Thread ausgefürt 
            var currentProgress = e.ProgressPercentage;
        }

        private void Backgroundworker_Aufgabe(object sender, DoWorkEventArgs e)
        {
            // Aufgabe, die der Backgroundworker im Hintergrund macht
            // ---- Auf einem anderen Thread
            worker.ReportProgress(10);


            worker.ReportProgress(100);
        }

        // Workaround: Mit Maus Scrollen aber nicht mit Toucheingabe
        private void ListBox_IsStylusCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == true) // Wenn Stylus
                ScrollViewer.SetVerticalScrollBarVisibility((DependencyObject)sender, ScrollBarVisibility.Disabled);
            else
                ScrollViewer.SetVerticalScrollBarVisibility((DependencyObject)sender, ScrollBarVisibility.Visible);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                // Notwending, weil wir direkt auf die progressbar direkt zugreifen
                Dispatcher.Invoke(() =>  progressBar.Value = 50);
            });
        }
        private BackgroundWorker worker;
    }
}
