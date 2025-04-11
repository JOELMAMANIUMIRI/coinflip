namespace Coinflip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int sorteio = random.Next(2);
             
            if(sorteio == 0)
            {
                MoedaImg.Source = "cara.jpg";
            }
            else
            {
                MoedaImg.Source = "coroa.jpg";
            }


            if (SelecaoPicker.SelectedIndex == sorteio)
            {
                DisplayAlert("Parabens", "você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }









        }


        
    }

}
