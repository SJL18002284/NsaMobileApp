using Firebase.Auth;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NsaMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string WebAPIkey = "AIzaSyDL-UIoPKUEs3JfXH1yViIuTjDeqh006k4";

        public LoginPage()
        {
            InitializeComponent();
        }

        FirestoreDb db = FirestoreDb.Create("cloudfire-NSAAuth");

        async void btnRegister_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(txtPassword.Text, txtPassword.Text);
                string gettoken = auth.FirebaseToken;
                await App.Current.MainPage.DisplayAlert("Alert", gettoken, "Ok");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
            //ADD
            string path = AppDomain.CurrentDomain.BaseDirectory + @"nsaauth-firebase-adminsdk-bd0tx-582e916832.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            Add_Document_with_AoutoID();


        }
        void Add_Document_with_AoutoID()
        {
           // string contact = txtContact.Text;
            string email = txtEmail.Text;
            //string fullname = txtFullname.Text;
            string password = txtPassword.Text;
            //string Usertype = listType.Text;
            DocumentReference doc = db.Collection("userstbl").Document(email);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
               // {"contact",contact },
                {"email",email },
               // {"fullname",fullname },
                {"password",password },
               // {"Usertype",Usertype},
            };
            doc.SetAsync(data1);
            DisplayAlert("Alert", "User Succesfully added", "OK");

        }

        //async void BtnSignIn_Clicked(System.Object sender, System.EventArgs e)
        //{
        //    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
        //    try
        //    {
        //        var auth = await authProvider.SignInWithEmailAndPasswordAsync(txtEmail.Text, txtPassword.Text);
        //        var content = await auth.GetFreshAuthAsync();
        //        var serializedcontnet = JsonConvert.SerializeObject(content);
        //        Preferences.Set("MyFirebaseRefreshToken", serializedcontnet);
        //        await Navigation.PushAsync(new HomePage());
        //    }
        //    catch (Exception ex)
        //    {
        //        await App.Current.MainPage.DisplayAlert("Alert", "Invalid useremail or password", "OK");
        //    }
        //}
    }
}