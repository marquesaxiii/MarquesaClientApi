using System;
using System.Collections.Generic;

namespace Client.Api.DataTransferObjects
{
    public partial class StudentInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;
    }
}
