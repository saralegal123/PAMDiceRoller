using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using DiceRollerPAM.Models;

namespace DiceRollerPAM
{
    public partial class MainPage : ContentPage
    {
        Dictionary<string, int> dados = new Dictionary<string, int>
       {
           { "D6", 6 }, { "D8", 8 }, { "D10", 10 }, { "D12", 12 }, { "D16", 16 }, { "D20", 20 }
       };
        Dice dado = new Dice();
        Contador contador = new Contador();
        public MainPage()
        {
            InitializeComponent();
            dicePicker.SelectedIndexChanged += DicePicker_SelectedIndexChanged;
        }
        private void DicePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = dicePicker.SelectedItem.ToString();
            int faces = dados[tipoSelecionado];
            numeroEscolhidoPicker.ItemsSource = Enumerable.Range(1, faces).ToList();
            dado.QuantidadeDeFaces = faces;
            // Define o limite da soma dos lados opostos
            switch (faces)
            {
                case 6: contador.Limite = 30; break;
                case 8: contador.Limite = 40; break;
                case 10: contador.Limite = 50; break;
                case 12: contador.Limite = 60; break;
                case 16: contador.Limite = 70; break;
                case 20: contador.Limite = 100; break;
            }
        }
        private void OnJogarClicked(object sender, EventArgs e)
        {
            if (dicePicker.SelectedItem == null || numeroEscolhidoPicker.SelectedItem == null)
                return;
            int numeroSelecionado = (int)numeroEscolhidoPicker.SelectedItem;
            dado.Sortear();
            contador.Jogar(dado, numeroSelecionado);
            resultadoLabel.Text = $"Resultado: {dado.FaceParaCima}";
            pontosLabel.Text = $"Pontos: {contador.Pontos}";
            sequenciaLabel.Text = $"Sequência: {contador.Sequencia}";
            somaLabel.Text = $"Soma das Faces Opostas: {contador.SomaOposta}";
            if (contador.Venceu == "fim")
            {
                resultadoLabel.Text = "Tentativas máximas utilizadas";
                ((Button)sender).IsEnabled = false;
            }
        }
    }
}