using NsaMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MongoDB.Driver;
using NsaMobileApp.Models;

namespace NsaMobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");


        }

        public IEnumerable<LoginPage> Get() 
        {
            var client = new MongoClient("mongodb://xbcad2021:<xbcad2021>@cluster0-shard-00-00.8vs9l.mongodb.net:27017,cluster0-shard-00-01.8vs9l.mongodb.net:27017,cluster0-shard-00-02.8vs9l.mongodb.net:27017/users?ssl=true&replicaSet=atlas-149y8y-shard-0&authSource=admin&retryWrites=true&w=majority");
            var database = client.GetDatabase("users");
            var collection = database.GetCollection<Item>("users");
            return null;
        }


        

        




    }
}
