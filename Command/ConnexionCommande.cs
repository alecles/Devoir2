using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Devoir2.ViewModel;

namespace Devoir2.Command
{
    class ConnexionCommande : ICommand
    {

        private MainViewModel viewModel;

        public ConnexionCommande(MainViewModel _viewModel)
        {
            viewModel = _viewModel;

        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
