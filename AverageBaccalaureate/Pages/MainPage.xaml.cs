using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AverageBaccalaureate.Models;
using AverageBaccalaureate.Pages;
using Xamarin.Forms;

namespace AverageBaccalaureate
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private double pageHeight;
        private int i, lastCountrySelected;
        private bool isClicked;
        public MainPage()
        {
            InitializeComponent();
            //FranceImage.Source = new UriImageSource
            //{
            //    Uri = new Uri("http://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Flag_of_France.png/320px-Flag_of_France.png"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(365,0,0,0,0)
            //};
            FranceImage.Source = "flag_france";
            MorocImage.Source = "flag_morocco";

            //MorocImage.Source = new UriImageSource
            //{
            //    Uri = new Uri("http://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Morocco.svg/200px-Flag_of_Morocco.svg.png"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(365,0, 0, 0, 0)
            //};
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lastCountrySelected = 0;
            if (i != 0)
            {
                await UpperStack.TranslateTo(0, 0, 500, Easing.Linear);
                await LowerStack.TranslateTo(0, pageHeight - 250.0, 500, Easing.Linear);
                MiddleStack.IsVisible = false;
            }
            i = 0;
            await Task.Delay(2000);
            // Uncomment to start the arrow Animation
            //new Command(async () => await LooperAnimation()).Execute(null);
        }
        protected override async void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            pageHeight = height;
            await LowerStack.TranslateTo(0, height - 250.0, 1);
        }
        private async Task LooperAnimation()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(700), () =>
            {
                Task.Factory.StartNew(async () =>
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Pays.TranslateTo(0, 8, 300);
                        await Pays.TranslateTo(0, -8, 300);
                    });
                });

                // Don't repeat the timer (we will start a new timer when the request is finished)
                return true;
            });
        }
        private async void PaysAnimateEvent(object sender, EventArgs e)
        {
            if (isClicked)
                return;
            isClicked = true;

            await AnimateScreen();

            await Task.Delay(1000);
            isClicked = false;
        }
        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            if (isClicked)
                return;
            isClicked = true;

            await AnimateScreen();

            await Task.Delay(1200);
            isClicked = false;
        }
        private async Task AnimateScreen()
        {
            new Command(async () => await MoveUpperStack()).Execute(null);
            new Command(async () => await MoveLowerStack()).Execute(null);
        }
        private async Task MoveUpperStack()
        {
            if (i == 0)
            {
                MiddleStack.IsVisible = true;
                await UpperStack.TranslateTo(0, -130.0, 500, Easing.Linear);
                i++;
            }
            else
            {
                await UpperStack.TranslateTo(0, 0, 500, Easing.Linear);
                MiddleStack.IsVisible = false;
                i = 0;
            }
        }

        private async void CountrySelected(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            if (frame.ClassId == "1")
            {
                FrancePicker.ItemsSource = MajorsList.GetList(1);
                CountryMoroc.BackgroundColor = Color.Transparent;
                CountryFrance.BackgroundColor = Color.LightGray;
                StackMorocoPicker.IsVisible = false;
                StackFrancePicker.IsVisible = true;
                // //
                //
                // //
                StackSimulationPicker.IsVisible = false;
                ButtonValider.IsVisible = false;
            }
            else if (frame.ClassId == "2")
            {
                MorocoPicker.ItemsSource = new List<string>()
                {
                    "Calcul Direct Moyennes",
                    "Saisir Notes Examen Bac"
                };
                CountryFrance.BackgroundColor = Color.Transparent;
                CountryMoroc.BackgroundColor = Color.LightGray;
                StackFrancePicker.IsVisible = false;
                StackMorocoPicker.IsVisible = true;
                // //
                //
                // //
                ButtonValider.IsVisible = false;
            }
            lastCountrySelected = Convert.ToInt32(frame.ClassId);
        }

        private async void Valider_Clicked(object sender, EventArgs e)
        {
            if (CountryFrance.BackgroundColor == Color.LightGray)
            {
                await Navigation.PushAsync(new FormsPage(1, (MajorDiscipline)FrancePicker.SelectedItem), true);
            }
            else if (CountryMoroc.BackgroundColor == Color.LightGray)
            {
                if (MorocoPicker.SelectedIndex == 0)
                {
                    await Navigation.PushAsync(new FormsPage(2, MorocoPicker.SelectedIndex), true);
                }
                else if (MorocoPicker.SelectedIndex == 1)
                {
                    await Navigation.PushAsync(new FormsPage(2, (MajorDiscipline)SimulationPicker.SelectedItem), true);
                }
            }
        }

        private void MorocPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MorocoPicker.SelectedIndex == 0)
            {
                StackSimulationPicker.IsVisible = false;
                ButtonValider.IsVisible = true;
            }
            else if (MorocoPicker.SelectedIndex == 1)
            {
                ButtonValider.IsVisible = false;
                SimulationPicker.ItemsSource = MajorsList.GetList(2);
                StackSimulationPicker.IsVisible = true;
            }
        }


        private void LastPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonValider.IsVisible = true;
        }

        private async Task MoveLowerStack()
        {
            if (i == 0)
            {
                await LowerStack.TranslateTo(0, 130.0, 500, Easing.Linear);
                i++;
            }
            else
            {
                await LowerStack.TranslateTo(0, pageHeight - 250.0, 500, Easing.Linear);
                i = 0;
            }
        }
    }
}
