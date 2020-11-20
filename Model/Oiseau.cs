using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir2.Model
{
    class Oiseau : Animal
    {
        private bool vole;

        public Oiseau(bool _vole, string _nom, int _age, string _couleur) : base(_nom, _age, _couleur, "Oiseau")
        {
            Vole = _vole;
        }


        public bool Vole { get => vole; set => vole = value; }
    }
}
