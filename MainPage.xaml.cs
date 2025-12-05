namespace IngridDemo3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        void OnCalculateBMI(object sender, EventArgs e)
        {
            var weight = 0.0;
            var height = 0.0;
            var bmiresult = 0.0;

            if ((Double.TryParse(inputWeight.Text, out weight)) && (Double.TryParse(inputHeight.Text, out height)))
            {
                bmiresult = weight / (height * height);
                outputResult.Text = string.Format("{0:##.00}", bmiresult);
            }
            else
            {
                outputResult.Text = "Please enter a valid value";
            }
            if (bmiresult < 18.5)
            {
                outputBmiStatus.Text = "Underweight";
                outputBmiStatus.BackgroundColor = Colors.Yellow;
            }
            else if ((bmiresult >= 18.5) && (bmiresult < 25))
            {
                outputBmiStatus.Text = "Normal";
                outputBmiStatus.BackgroundColor = Colors.Green;
                outputBmiStatus.TextColor = Colors.White;
            }
            else if ((bmiresult >= 25) && (bmiresult < 30))
            {
                outputBmiStatus.Text = "Overweight";
                outputBmiStatus.BackgroundColor = Colors.Orange;
                outputBmiStatus.TextColor = Colors.White;
            }
            else if ((bmiresult >= 30))
            {
                outputBmiStatus.Text = "Obese";
                outputBmiStatus.BackgroundColor = Colors.Red;
                outputBmiStatus.TextColor = Colors.White;
            }


        }
        void OnReset(object sender, EventArgs e)
        {
            inputWeight.Text = null;
            inputHeight.Text = null;
            outputResult.Text = "0.00";
            outputBmiStatus.Text = "Not Available";
            outputBmiStatus.BackgroundColor = Colors.Transparent;
            outputBmiStatus.TextColor = Colors.Black;

        }

    }
}
