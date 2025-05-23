using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerPAM
{
    using System;
    namespace DiceRollerPAM
    {
        internal class Contador
        {
            public int Sequencia;
            public int Pontos;
            public int Limite;
            public string Venceu;
            public int SomaOposta;
            public void Jogar(Dice DadoJogador, int numeroSelecionado)
            {
                int n = DadoJogador.FaceParaBaixo;
                if (DadoJogador.FaceParaCima == numeroSelecionado)
                {
                    Pontos++;
                    Sequencia++;
                }
                else
                {
                    Sequencia = 0;
                }
                SomaOposta += n;
                if (SomaOposta >= Limite)
                {
                    Venceu = "fim";
                }
                else
                {
                    Venceu = "";
                }
            }
        }
    }
}
