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
                core = core ?? new Core(UoW);
                return core;
            }
        }

        private IUnitOfWork uow;
        public IUnitOfWork UoW
        {
            get
            {
                uow = uow ?? new EFUnitOfWork(new EFContext());
                return uow;
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
