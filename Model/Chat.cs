using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir2.Model
{
    class Chat : Animal
    {
        private int pattes;

        public Chat(int _pattes, string _nom, int _age, string _couleur) : base(_nom, _age, _couleur, "Chat")
        {
            pattes = _pattes;
        }

        public int Pattes { get => pattes; set => pattes = value; }
    }
}
