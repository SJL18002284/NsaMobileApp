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
    public partial class HomePage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public HomePage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allRequests = await firebaseHelper.GetAllRequests();
            lstRequests.ItemsSource = allRequests;
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DonationPage());
        }
    }
}