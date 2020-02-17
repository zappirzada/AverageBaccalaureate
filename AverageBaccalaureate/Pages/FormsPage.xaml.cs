using System;
using System.Collections.Generic;
using System.Diagnostics;
using AverageBaccalaureate.Models;
using AverageBaccalaureate.ViewModels;
using Xamarin.Forms;

namespace AverageBaccalaureate.Pages
{
    public partial class FormsPage : ContentPage
    {
        private int CountryId;
        private MajorDiscipline SelectedMajor;
        private int MorocSelectedIndexPickerOne = -1;
        public const string INTERSTITIAL_AD_ANDROID = "ca-app-pub-8435060720963065/9388117933";
        public const string INTERSTITIAL_AD_IOS = "ca-app-pub-8435060720963065/6449349003";
        private string interstitialAdId;
        public FormsPage(int CountryId, MajorDiscipline SelectedMajor)
        {
            InitializeComponent();
            this.CountryId = CountryId;
            this.SelectedMajor = SelectedMajor;
            Title = "Votre Filière: " + SelectedMajor.Name;
        }
        public FormsPage(int CountryId, int MorocSelectedIndexPickerOne)
        {
            InitializeComponent();

            this.CountryId = CountryId;
            this.MorocSelectedIndexPickerOne = MorocSelectedIndexPickerOne;
            Title = "Calcul Moyenne Direct";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                if (CountryId == 1)
                {
                    FranceStack.IsVisible = true;
                    BindingContext = new FranceViewModel(SelectedMajor);
                }
                else if (CountryId == 2 && MorocSelectedIndexPickerOne == -1)
                {
                    MorocOption2Stack.IsVisible = true;
                    BindingContext = new MorocViewModel(SelectedMajor);
                }
                else if (CountryId == 2 && MorocSelectedIndexPickerOne == 0)
                {
                    MorocOption1Stack.IsVisible = true;
                    BindingContext = new MorocViewModel();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async void Calculer_Clicked(object sender, EventArgs e)
        {
            calculateMoyenne();
        }

        private async void calculateMoyenne()
        {
            try
            {
                double res = 0.0;
                double upper = 0.0;
                double lower = 0.0;
                if (CountryId == 1)
                {
                    foreach (var Items in ((FranceViewModel)BindingContext).GroupedSubjectCoeffs)
                    {
                        foreach (var item in Items)
                        {
                            if ((!item.SwitchToGetCoeff || item.ListTitle == "Option 1" || item.ListTitle == "Option 2") && (string.IsNullOrEmpty(item.Note)))
                                item.Note = "0"; //Just to pass the check below

                            if (string.IsNullOrEmpty(item.Note))
                                return;

                            if (item.SwitchToGetCoeff)
                            {
                                if (Convert.ToDouble(item.Note) > 20.0)
                                {
                                    await DisplayAlert("Alerte", "Les valeurs d'entrée ne peuvent être inférieures à 20", "D'accord");
                                    return;
                                }
                                if (item.ListTitle == "Option 1" || item.ListTitle == "Option 2")
                                {
                                    if (item.ActualCoefficient != 0.0)
                                    {
                                        upper += Convert.ToDouble(item.Note) * Convert.ToDouble(item.ActualCoefficient);
                                        lower += Convert.ToDouble(item.ActualCoefficient);
                                    }
                                    else
                                    {
                                        //if (item.ListTitle == "Option 1")
                                        //{
                                        //    await DisplayAlert("Alerte", "Veuillez sélectionner l'option 1 ou supprimer sa note.", "D'accord");
                                        //    return;
                                        //}
                                        //else if (item.ListTitle == "Option 2")
                                        //{
                                        //    await DisplayAlert("Alerte", "Veuillez sélectionner 2'option 1 ou supprimer sa note.", "D'accord");
                                        //    return;
                                        //}
                                    }
                                }
                                else
                                {
                                    upper += Convert.ToDouble(item.Note) * Convert.ToDouble(item.ActualCoefficient);
                                    lower += Convert.ToDouble(item.ActualCoefficient);
                                }
                            }
                        }
                    }
                    res = upper / lower;
                    if (res > 20.0)
                    {
                        await DisplayAlert("Alerte", "Les valeurs d'entrée ne peuvent être inférieures à 20", "D'accord");
                        return;
                    }
                }
                else if (CountryId == 2 && MorocSelectedIndexPickerOne == -1)
                {
                    if (string.IsNullOrWhiteSpace(MorocOption2Entry1.Text) || string.IsNullOrWhiteSpace(MorocOption2Entry2.Text))
                        return;
                    if (Convert.ToDouble(MorocOption2Entry1.Text) > 20.0 || Convert.ToDouble(MorocOption2Entry2.Text) > 20.0)
                    {
                        await DisplayAlert("Alerte", "Les valeurs d'entrée ne peuvent être inférieures à 20", "D'accord");
                        return;
                    }
                    foreach (var Items in ((MorocViewModel)BindingContext).GroupedSubjectCoeffs)
                    {
                        foreach (var item in Items)
                        {
                            if (string.IsNullOrEmpty(item.Note))
                                return;
                            if (item.SwitchToGetCoeff)
                            {
                                if (Convert.ToDouble(item.Note) > 20.0)
                                {
                                    await DisplayAlert("Alerte", "Les valeurs d'entrée ne peuvent être inférieures à 20", "D'accord");
                                    return;
                                }
                                upper += Convert.ToDouble(item.Note) * Convert.ToDouble(item.ActualCoefficient);
                                lower += Convert.ToDouble(item.ActualCoefficient);
                            }
                        }
                    }
                    res = upper / lower;
                    res = ((Convert.ToDouble(MorocOption2Entry1.Text) * 0.25) + (Convert.ToDouble(MorocOption2Entry2.Text) * 0.25) + (res * 0.5));
                    if (res > 20.0)
                    {
                        await DisplayAlert("Alerte", "Les valeurs d'entrée ne peuvent être inférieures à 20", "D'accord");
                        return;
                    }
                }
                else if (CountryId == 2 && MorocSelectedIndexPickerOne == 0)
                {
                    foreach (var Items in ((MorocViewModel)BindingContext).GroupedSubjectCoeffs)
                    {
                        foreach (var item in Items)
                        {
                            if (string.IsNullOrEmpty(item.Note))
                                return;
                            if (item.SwitchToGetCoeff)
                            {
                                if (Convert.ToDouble(item.Note) > 20.0)
                                {
                                    await DisplayAlert("Alerte", "Les valeurs d'entrée ne peuvent être inférieures à 20", "D'accord");
                                    return;
                                }
                                upper += Convert.ToDouble(item.Note) * Convert.ToDouble(item.ActualCoefficient);
                            }
                        }
                    }
                    res = upper;
                }
                // //
                // Navigate to next page with values
                // //
                await Navigation.PushAsync(new ResultPage(res), true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void Current_OnInterstitialLoaded(object sender, EventArgs e)
        {
            //CrossMTAdmob.Current.ShowInterstitial();
        }

        private void Current_OnInterstitialClosed(object sender, EventArgs e)
        {
            calculateMoyenne();
        }
    }
}
