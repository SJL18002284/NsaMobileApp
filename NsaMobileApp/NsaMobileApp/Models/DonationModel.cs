using System;
using System.Collections.Generic;
using System.Text;

namespace NsaMobileApp.Models
{
    class DonationModel
    {
        public int donationID { get; set; }

        public string doneeName { get; set; }

        public string doneeEmail { get; set; }

        public string doneeNo { get; set; }

        public string donationDetails { get; set; }

        public string donationDate { get; set; }

        public DonationModel()
        {
            //empty constructor
        }

        public DonationModel(int donationID, string doneeName, string doneeEmail, string doneeNo, string donationDetails, string donationDate)
        {
            this.donationID = donationID;
            this.doneeName = doneeName;
            this.doneeEmail = doneeEmail;
            this.doneeNo = doneeNo;
            this.donationDetails = donationDetails;
            this.donationDate = donationDate;
        }
    }
}
