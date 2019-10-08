using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.UI.WPF.ViewModels;
using System;
using System.Collections.Generic;
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
            // Variante 1)
            // this.DataContext = new MainViewModel(new Logic.Core(new EFRepository(new EFContext())));
        }

        // Workaround: Mit Maus Scrollen aber nicht mit Toucheingabe
        private void ListBox_IsStylusCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == true) // Wenn Stylus
                ScrollViewer.SetVerticalScrollBarVisibility((DependencyObject)sender, ScrollBarVisibility.Disabled);
            else
                ScrollViewer.SetVerticalScrollBarVisibility((DependencyObject)sender, ScrollBarVisibility.Visible);
        }
    }
}
