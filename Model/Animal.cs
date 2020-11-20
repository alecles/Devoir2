using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir2.Model
{
    class Animal
    {
        private string nom;
        private int age;
        private string couleur;
        private string typeAnimal;

        public Animal(string _nom, int _age, string _couleur, string _typeAnimal)
        {
            nom = _nom;
            age = _age;
            couleur = _couleur;
            typeAnimal = _typeAnimal;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Age { get => age; set => age = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public string TypeAnimal { get => typeAnimal; set => typeAnimal = value; }
    }
}
