using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Devoir2.Command;
using Devoir2.Model;

namespace Devoir2.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        object selectedControl;
        object selectedMenu;

        public ICommand connexionCommande { get; set; }
        public Usager usager { get; set; }
        public MainViewModel()
        {
            usager = new Usager();

            connexionCommande = new BaseCommand(LoadAnimalViewModel, obj => true);
            selectedMenu = new MenuViewModel();
            selectedControl = this;
        }
        public object SelectMenu
        {
            get => selectedMenu;
            set
            {
                selectedMenu = value;
                OnPropertyChanged("SelectMenu");
            }
        }

        public object SelectControl
        {
            get => selectedControl;
            set
            {
                selectedControl = value;
                OnPropertyChanged("SelectControl");
            }
        }
        public void LoadAnimalViewModel(object parameter)
        {
            if (CanUpdate)
                SelectControl = new ViewModel.AnimalViewModel();
        }
        public bool CanUpdate
        {
            get
            {
                if (usager.Nom != "Xavier")
                    return false;
                else
                    return true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
