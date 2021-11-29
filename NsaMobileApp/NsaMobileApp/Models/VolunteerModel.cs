using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace NsaMobileApp.Models
{
    public class VolunteerModel
    {
        [Key]
        public string VolunteerID { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                            ErrorMessage = "Please enter a valid email address")]
        public string userEmail { get; set; }

        [Required(ErrorMessage = "Full Name cannot be empty")]
        public string fullName { get; set; }

        [Required(ErrorMessage = "Contact Number cannot be empty")]
        public string contactNo { get; set; }

        public VolunteerModel()
        {
        }

        public VolunteerModel(string userEmail, string fullName, string contactNo)
        {
            this.userEmail = userEmail;
            this.fullName = fullName;
            this.contactNo = contactNo;
        }

        public VolunteerModel(string volunteerID, string userEmail, string fullName, string contactNo)
        {
            VolunteerID = volunteerID;
            this.userEmail = userEmail;
            this.fullName = fullName;
            this.contactNo = contactNo;
        }
    }
}
