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
using System.Threading.Tasks;

namespace ppedv.LibertyBooks.UI.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            core = new Core(new EFRepository(new EFContext()));
            GetBooksCommand = new Command(GetBooks);

            // Richtig: Über DependencyInjection
        }
        private readonly Core core; // <--- Model

        private void GetBooks()
        {
            Books = core.GetAllBooks().ToList();
        }

        private List<Book> books;
        public List<Book> Books
        {
            get => books;
            set => SetProperty(ref books, value);
        }
        public Command GetBooksCommand { get; set; }
    }
}
