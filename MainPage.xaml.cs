namespace RGB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = SliderR.Value;
            var green = SliderG.Value;
            var blue = SliderB.Value;

            var color = Color.FromRgb(red, green, blue);
            Kwadrat.Fill = new SolidColorBrush(color);

        }
    }

}
