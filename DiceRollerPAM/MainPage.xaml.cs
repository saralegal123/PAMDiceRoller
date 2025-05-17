namespace DiceRollerPAM
{
    public partial class MainPage : ContentPage
    {
        Dice dado = new Dice();
        Contador contador = new Contador();
        public MainPage()
        {
            InitializeComponent();
            dicePicker.SelectedIndexChanged += DicePicker_SelectedIndexChanged;
        }
        private void DicePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dicePicker.SelectedItem == null) return;
            string tipo = dicePicker.SelectedItem.ToString();
            int faces = int.Parse(tipo.Substring(1)); // Pega o número do tipo (ex: D6 -> 6)
            dado.QuantidadeDeFaces = faces;
            numeroEscolhidoPicker.ItemsSource = Enumerable.Range(1, faces).ToList();
        }
        private void OnJogarClicked(object sender, EventArgs e)
        {
            if (numeroEscolhidoPicker.SelectedItem == null || dicePicker.SelectedItem == null)
                return;
            int numeroEscolhido = (int)numeroEscolhidoPicker.SelectedItem;
            dado.Sortear();
            contador.Jogar(dado, numeroEscolhido);
            resultadoLabel.Text = $"Você tirou {dado.FaceParaCima} | Face Opostada: {dado.FaceParaBaixo}";
            pontosLabel.Text = $"Pontos: {contador.Pontos}";
            sequenciaLabel.Text = $"Sequência: {contador.Sequencia}";
            somaLabel.Text = $"Soma das Faces Opostas: {contador.Limite}";
            if (contador.Venceu == "fim")
            {
                resultadoLabel.Text = "Tentativas máximas utilizadas";
            }
        }
    }
}
