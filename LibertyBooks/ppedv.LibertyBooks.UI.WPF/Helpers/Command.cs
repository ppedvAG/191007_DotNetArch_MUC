﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ppedv.LibertyBooks.UI.WPF.Helpers
{
    public class Command : ICommand
    {
        public Command(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute ?? new Func<bool>(() => true);
        }
        private Action execute;
        private Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return canExecute();
        }
        public void Execute(object parameter)
        {
            execute();
        }
    }
}
