using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NsaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DonationPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public DonationPage()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.AddDonation(Convert.ToString(Date.Date), 
                                             FullName.Text,
                                             Email.Text.ToString(),
                                             ContactNo.Text.ToString(),
                                             Details.Text.ToString());
            FullName.Text = string.Empty;
            Email.Text = string.Empty;
            ContactNo.Text = string.Empty;
            Details.Text = string.Empty;
            await DisplayAlert("Success", "Donation Successfully processed", "OK");
            //var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        }
    }
}