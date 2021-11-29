using Xamarin.Forms;
using Xamarin.Essentials;
using System;
using System.Threading.Tasks;

namespace NsaMobileApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        async void btnCall_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number.Text))
            {
                await Call(Number.Text);
            }
        }
        public async Task Call(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (FeatureNotSupportedException ex)
            {
                Number.Text = "Phone Dialer is not supported on this device.";
            }
            catch (Exception ex)
            {
                // Other error has occurred.  
            }
        }

    }
}