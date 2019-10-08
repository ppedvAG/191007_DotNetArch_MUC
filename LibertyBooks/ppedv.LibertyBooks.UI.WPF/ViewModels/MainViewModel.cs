using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Logic;
using ppedv.LibertyBooks.UI.WPF.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ppedv.LibertyBooks.UI.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(Core core)
        {
            // Dependency-Injection
            this.core = core;
            GetBooksCommand = new Command(GetBooks);
            CancelGetBooksCommand = new Command(CancelGetBooks);
            UIEnabled = true;
        }

        private void CancelGetBooks()
        {
            cts.Cancel();
        }

        private readonly Core core; // <--- Model
        private CancellationTokenSource cts = new CancellationTokenSource();

        private void GetBooks()
        {
            Task t1 = Task.Run(() =>
            {
                UIEnabled = false;
                Progress = 0;
                Thread.Sleep(1000);
                Progress = 10;
                Thread.Sleep(3000);
                Progress = 50;
                if (cts.Token.IsCancellationRequested)
                    return;
                Thread.Sleep(2000);
                Books = core.GetAllBooks().ToList();
                Progress = 100;
                UIEnabled = true;
            });

            // if(t1.Status == TaskStatus.Faulted)
                // task hat einen fehler -> mach was ....
        }

        private List<Book> books;
        public List<Book> Books
        {
            get => books;
            set => SetProperty(ref books, value);
        }
        public Command GetBooksCommand { get; set; }
        public Command CancelGetBooksCommand { get; set; }

        private double progress;
        public double Progress 
        {
            get => progress;
            set => SetProperty(ref progress, value);
        }

        private bool uiEnabled;
        public bool UIEnabled
        {
            get => uiEnabled;
            set => SetProperty(ref uiEnabled, value);
        }
    }
}
