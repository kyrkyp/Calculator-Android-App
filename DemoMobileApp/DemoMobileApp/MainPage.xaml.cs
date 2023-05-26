using System;
using Xamarin.Forms;

namespace DemoMobileApp
{
    public partial class MainPage : ContentPage
    {
        private Label label;
        private int number1;
        private int number2;
        private string symbol;
        private bool isFirstClick = true;

        public MainPage()
        {
            InitializeComponent();

            label = this.FindByName<Label>("text");
        }

        private void HandleClickOnNumber(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            label.Text += " " + num;

            if (isFirstClick)
            {
                isFirstClick = false;
                number1 = int.Parse(num);
            }
            else
            {
                number2 = int.Parse(num);
            }
        }

        private void HandleClickOnSymbol(object sender, EventArgs e)
        {
            string sign = (sender as Button).Text;
            symbol = sign;
            label.Text += " " + sign;
        }

        private void HandleClickOnClear(object sender, EventArgs e)
        {
            isFirstClick = true;
            label.Text = "";
        }

        private void HandleClickOnEquals(object sender, EventArgs e)
        {
            int result = 0;

            switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "%":
                    result = number1 % number2;
                    break;
            }

            label.Text += " = " + result.ToString();
        }
    }
}