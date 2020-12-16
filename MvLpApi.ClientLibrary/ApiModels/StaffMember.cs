using System;
using System.Collections.Generic;
using System.Text;

namespace MvLpApi.ClientLibrary.ApiModels
{
    public class StaffMember
    {
        public int Id { get; set; }
        public string NationalRegistrationNumber { get; set; }
        public string Signature { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public bool MayExposeMobilePhoneToStudents { get; set; }
    }
}
