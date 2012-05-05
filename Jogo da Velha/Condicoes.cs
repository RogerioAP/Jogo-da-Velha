using System;/*Rogério Almeida Pereira*/
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogodaVelha
{
    public class Condicoes
    {
        public int a = 1;
        public string jog;

        public int Jogador() //esse Jogador() serve para ficar alternando o label lá emcima, para definir se é jogador 1 ou 2 
        {
            a++;
            return a;
            //números ÍMPARES é do jogador 1
            //números PARES é do jogador 2
        }
    }
}
