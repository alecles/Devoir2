using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir2.Model
{
    class Poisson : Animal
    {
        private int vitesse;

        public Poisson(int _vitesse, string _nom, int _age, string _couleur) : base(_nom, _age, _couleur, "Poisson")
        {
            vitesse = _vitesse;
        }
        public int Vitesse { get => vitesse; set => vitesse = value; }
    }
}
