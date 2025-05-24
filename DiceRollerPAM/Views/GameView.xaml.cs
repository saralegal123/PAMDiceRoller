using DiceRollerPAM.ViewModels;
using Microsoft.Maui.Controls;

namespace DiceRollerPAM.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
        BindingContext = new GameViewModel();
		InitializeComponent();
	}
}