using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using NsaMobileApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NsaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DonationRequestPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public DonationRequestPage()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.AddVolunteer(Email.Text.ToString(),
                                              FullName.Text.ToString(),
                                              ContactNo.Text.ToString());
            FullName.Text = string.Empty;
            Email.Text = string.Empty;
            ContactNo.Text = string.Empty;
           
            await DisplayAlert("Success", "Volunteer Application Successfully Processed", "OK");
            //var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        }

    }
}