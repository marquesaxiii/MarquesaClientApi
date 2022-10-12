using System;
using System.Collections.Generic;

namespace Client.Api.DataTransferObjects
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
