using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerPAM
{
    internal class Contador
    {
            public int Sequencia;
            public int Pontos;
            public int Limite;
            public string Venceu;

            public void Jogar(Dice DadoJogador, int numeroSelecionado)
            {
                int n = DadoJogador.FaceParaBaixo;
            }
    }
}
