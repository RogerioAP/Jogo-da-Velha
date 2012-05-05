using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogodaVelha
{
    public class Condicoes
    {
        public int a = 1;
        public string jog;

        public int Jogador()
        {
            a++;
            return a;
            //números ÍMPARES é do jogador 1
            //números PARES é do jogador 2
        }
    }
}
