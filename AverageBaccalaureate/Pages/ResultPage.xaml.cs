using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AverageBaccalaureate.Pages
{
    public partial class ResultPage : ContentPage
    {
        public string Result { get; set; }
        public ResultPage(double v)
        {
            InitializeComponent();
            Result = String.Format("{0:0.##}", v);
            ResultLabel.Text = String.Format("{0:0.##}", v);
            if (v < 10.0)
            {
                LabelMention.Text = ":(";
                ResultImage.Source = "goodluck.jpg";
            }
            else if (v < 12.0 && v >= 10.0)
            {
                LabelMention.Text = "Passable";
                ResultImage.Source = "congratulations.jpg";
            }
            else if (v < 14.0 && v >= 12.0)
            {
                LabelMention.Text = "Assez-Bien";
                ResultImage.Source = "congratulations.jpg";
            }
            else if (v < 16.0 && v >= 14.0)
            {
                LabelMention.Text = "Bien";
                ResultImage.Source = "congratulations.jpg";
            }
            else if (v >= 16.0)
            {
                LabelMention.Text = "Très-Bien";
                ResultImage.Source = "congratulations.jpg";
            }
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
        }
    }
}
