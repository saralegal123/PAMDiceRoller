using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerPAM.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string diceImage;

        [ObservableProperty]
        private string nomeUsuario;

        GameViewModel() {
            diceImage = "dice1.png";
            nomeUsuario = "Eu";

        }

    }
}
