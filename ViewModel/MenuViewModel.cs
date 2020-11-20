using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Devoir2.Command;

namespace Devoir2.ViewModel
{
    class MenuViewModel : INotifyPropertyChanged
    {
        public ICommand quitterCommande { get; set; }
        public ICommand sauvegarderCommande { get; set; }

        public MenuViewModel()
        {
            quitterCommande = new QuitterCommande(LoadQuitter, obj => true);
            sauvegarderCommande = new SauvegarderCommande(LoadSauvegarder, obj => true);
        }
        public void LoadQuitter(object parameter)
        {
            MessageBox.Show("Appuyer sur le bouton X pour quitter la page");
        }
        public void LoadSauvegarder(object parameter)
        {
            MessageBox.Show("Vous ne pouvez pas sauvegarder");
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
