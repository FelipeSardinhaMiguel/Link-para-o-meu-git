namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "arquivo");

        public MainPage()
        {
            InitializeComponent();
        }

        private void ApagarTextBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        private void SalvarTextBtn_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);




        }
    }

}
