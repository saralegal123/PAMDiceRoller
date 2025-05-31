using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerPAM.Models
{
    internal class Dice
    {
        //Atributos - utilizamos property nesse caso. (public tipo nome)
        public int FaceParaBaixo;
        public int FaceParaCima;
        public int QuantidadeDeFaces;

        //método de sorteio dos lados do dado
        public void Sortear()
        {
            Random random = new Random();
            FaceParaCima = random.Next(1, QuantidadeDeFaces + 1);
            //a soma mágica = o menor lado possível + o maior 
            //a soma mágica = 1 + quantidade
            FaceParaBaixo = 1 + QuantidadeDeFaces - FaceParaCima;
        }
    }
}
