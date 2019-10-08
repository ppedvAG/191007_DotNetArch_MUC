using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Domain.Interfaces;
using ppedv.LibertyBooks.Logic;
using ppedv.LibertyBooks.UI.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.LibertyBooks.UI.WPF.Helpers
{
    // Container
    public class ViewModelLocator
    {
        // Ort für alle ViewModels und deren abhängigkeiten
        // Bonuspunkte: IoC - Container
        // --- Beispiel: Autofac, Unity, SimpleIoC ...
        private Core core;
        public Core Core
        {
            get
            {
                core = core ?? new Core(Repository);
                return core;
            }
        }

        private IRepository repository;
        public IRepository Repository
        {
            get
            {
                repository = repository ?? new EFRepository(new EFContext());
                return repository;
            }
        }

        private MainViewModel main;
        public MainViewModel Main
        {
            get
            {
                main = main ?? new MainViewModel(Core);
                return main;
            }
        }

    }
}
