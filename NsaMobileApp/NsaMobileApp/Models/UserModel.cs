using System;
using System.Collections.Generic;
using System.Text;

namespace NsaMobileApp.Models
{
    class UserModel
    {
        public string userID { get; set; }

        public string userEmail { get; set; }

        public string userName { get; set; }

        public string userPassword { get; set; }

        public string userContactNo { get; set; }

        public UserModel()
        {
        }

        public UserModel(string userID, string userEmail, string userName, string userPassword, string userContactNo)
        {
            this.userID = userID;
            this.userEmail = userEmail;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userContactNo = userContactNo;
        }
    }
}
