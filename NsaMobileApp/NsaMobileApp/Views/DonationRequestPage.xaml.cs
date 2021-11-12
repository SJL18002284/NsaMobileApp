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
        

        //initializing the db
        //FirestoreDb db = FirestoreDb.Create("NsaDb");

        //Document reference 
        //DocumentReference doc;

        public DonationRequestPage()
        {
            InitializeComponent();
        }

    //    private void createDonation()
    //    {
    //        //model
    //        DonationRequestModel model = new DonationRequestModel();

    //        //list
    //        List<DonationRequestModel> list = new List<DonationRequestModel>();

    //        //variables to hold user input
    //        string create_Date = Date.Date.ToString();
    //        string cause_Name = CauseName.Text;
    //        string org_Name = OrganizerName.Text;
    //        string req_Dets = Details.Text;
    //        string org_email = Email.Text;
    //        string org_Num = ContactNo.Text;

    //        //Collection that will be used
    //        doc = db.Collection("DonationRequestsTbl").Document(cause_Name);

    //        //adding the inputs to the list
    //        list.Add(new DonationRequestModel(create_Date, cause_Name, org_Name, req_Dets, org_email, org_Num));

    //        doc.SetAsync(list);
    //        DisplayAlert("Alert", "Request Successfully Created", "OK");
    //    }
    }
}