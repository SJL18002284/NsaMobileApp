using Firebase.Database;
using Firebase.Database.Query;
using NsaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsaMobileApp
{
    
    class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://nsaauth-default-rtdb.firebaseio.com/");

        public async Task<List<DonationRequestModel>> GetAllRequests()
        {
            return (await firebase
              .Child("Requests")
              .OnceAsync<DonationRequestModel>()).Select(item => new DonationRequestModel
              {
                  requestID = item.Object.requestID,
                  requestDate = item.Object.requestDate,
                  causeName = item.Object.causeName,
                  requestCategory = item.Object.requestCategory,
                  requestDetails = item.Object.requestDetails,
                  organizerName = item.Object.organizerName,
                  organizerEmail = item.Object.organizerEmail,
                  organizerContactNo = item.Object.organizerContactNo,
                  userID = item.Object.userID
              }).ToList();
        }

        public async Task AddDonation(string doneeName, string doneeEmail, string doneeNo, string donationDetails, string donationDate)
        {

            await firebase
              .Child("Donations")
              .PostAsync(new DonationModel() { 
                                               doneeName = doneeName,
                                               doneeEmail = doneeEmail,
                                               doneeNo = doneeNo,   
                                               donationDetails = donationDetails,    
                                               donationDate = donationDate});
        }

        public async Task AddVolunteer(string userEmail, string fullName, string contactNo)
        {

            await firebase
              .Child("Volunteers")
              .PostAsync(new VolunteerModel()
              {
                  userEmail = userEmail,
                  fullName = fullName,
                  contactNo = contactNo
              });
        }
    }

    
}
