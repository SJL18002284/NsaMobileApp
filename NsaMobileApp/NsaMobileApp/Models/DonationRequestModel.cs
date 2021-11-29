using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace NsaMobileApp.Models
{
    class DonationRequestModel
    {

        [Key]
        public string requestID { get; set; }

        [Required(ErrorMessage = "Request Date cannot be empty")]
        public string requestDate { get; set; }

        [Required(ErrorMessage = "Cause Name cannot be empty")]
        public string causeName { get; set; }

        [Required(ErrorMessage = "Request Category cannot be empty")]
        public string requestCategory { get; set; }

        [Required(ErrorMessage = "Organizer Name cannot be empty")]
        public string organizerName { get; set; }

        [Required(ErrorMessage = "Organizer Email cannot be empty")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                            ErrorMessage = "Please enter a valid email address")]
        public string organizerEmail { get; set; }

        [Required(ErrorMessage = "Organizer ContactNo cannot be empty")]
        public string organizerContactNo { get; set; }

        [Required(ErrorMessage = "Request Details cannot be empty")]
        public string requestDetails { get; set; }

        public string userID { get; set; }


        //empty constructor
        public DonationRequestModel()
        {

        }

        public DonationRequestModel(string requestID, string requestDate, string causeName, string requestCategory, string organizerName, string organizerEmail, string organizerContactNo, string requestDetails, string userID) : this(requestID, requestDate, causeName, requestCategory, organizerName, organizerEmail, organizerContactNo, requestDetails)
        {
            this.userID = userID;
            this.requestDate = requestDate;
            this.causeName = causeName;
            this.requestCategory = requestCategory;
            this.organizerName = organizerName;
            this.organizerEmail = organizerEmail;
            this.organizerContactNo = organizerContactNo;
            this.requestDetails = requestDetails;
            this.userID = userID;
        }

        //constructor accepting parameters
        public DonationRequestModel(string requestDate, string causeName, string requestCategory, string organizerName, string organizerEmail, string organizerContactNo, string requestDetails, string userID)
        {
            this.requestDate = requestDate;
            this.causeName = causeName;
            this.requestCategory = requestCategory;
            this.organizerName = organizerName;
            this.organizerEmail = organizerEmail;
            this.organizerContactNo = organizerContactNo;
            this.requestDetails = requestDetails;
            this.userID = userID;
        }


    }
}
