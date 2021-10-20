using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace NsaMobileApp.Models
{
    class DonationRequestModel
    {
        
        //variables of the request
        
        public int requestID { get; set; }

        //[Required(ErrorMessage = "Request Date cannot be empty")]
        public string requestDate { get; set; }
        
        //[Required(ErrorMessage = "Cause Name cannot be empty")]
        public string causeName { get; set; }
        
        //[Required(ErrorMessage = "Organizer Name cannot be empty")]
        public string organizerName { get; set; }
        
        //[Required(ErrorMessage = "Organizer Email cannot be empty")]
        public string organizerEmail { get; set; }
        
        //[Required(ErrorMessage = "Organizer ContactNo cannot be empty")]
        public int organizerContactNo { get; set; }
        
        //[Required(ErrorMessage = "Request Details cannot be empty")]
        public string requestDetails { get; set; }

        //empty constructor

        public DonationRequestModel()
        {

        }

        //constructor accepting parameters
        public DonationRequestModel(int requestID, string requestDate, string causeName, string organizerName, string organizerEmail, int organizerContactNo, string requestDetails)
        {
            this.requestID = requestID;
            this.requestDate = requestDate;
            this.causeName = causeName;
            this.organizerName = organizerName;
            this.organizerEmail = organizerEmail;
            this.organizerContactNo = organizerContactNo;
            this.requestDetails = requestDetails;
        }

        //constructor without ID
        public DonationRequestModel(string requestDate, string causeName, string organizerName, string organizerEmail, int organizerContactNo, string requestDetails)
        {
            this.requestDate = requestDate;
            this.causeName = causeName;
            this.organizerName = organizerName;
            this.organizerEmail = organizerEmail;
            this.organizerContactNo = organizerContactNo;
            this.requestDetails = requestDetails;
        }


    }
}
