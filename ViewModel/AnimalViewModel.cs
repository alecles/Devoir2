using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devoir2.Model;

namespace Devoir2.ViewModel
{
    class AnimalViewModel
    {
        private ObservableCollection<Animal> animaux;

        public AnimalViewModel()
        {
            animaux = new ObservableCollection<Animal>
            {
                new Chat(4,"Robert",45,"Vert"),
                new Poisson(112,"Jorris",1,"Poivre"),
                new Oiseau(true,"Ron",3,"Orange")
            };
        }
    }
}
