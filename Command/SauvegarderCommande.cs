using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Devoir2.Command
{
    class SauvegarderCommande : ICommand
    {
        public SauvegarderCommande(Action<object> execute, Predicate<object> canExecute)
        {

            ExecuteFunc = execute;
            CanExecuteFunc = canExecute;

        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return CanExecuteFunc(parameter);
        }

        public Predicate<object> CanExecuteFunc
        {
            get;
            set;
        }
        public Action<object> ExecuteFunc
        {
            get;
            set;
        }

        public void Execute(object parameter)
        {

            ExecuteFunc(parameter);
        }
    }
}
