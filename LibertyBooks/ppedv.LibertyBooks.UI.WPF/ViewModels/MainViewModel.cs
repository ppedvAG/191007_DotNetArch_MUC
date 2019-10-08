using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Logic;
using ppedv.LibertyBooks.UI.WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.LibertyBooks.UI.WPF.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            core = new Core(new EFRepository(new EFContext()));
            GetBooksCommand = new Command(GetBooks);

            // Richtig: Über DependencyInjection
        }

        private void GetBooks()
        {
            Books = core.GetAllBooks().ToList();
        }

        private readonly Core core; // <--- Model

        public List<Book> Books { get; set; }
        public Command GetBooksCommand { get; set; }
    }
}
