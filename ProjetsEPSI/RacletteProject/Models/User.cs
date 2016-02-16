using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RacletteProject.Domain
{
    public class User
    {
        Guid Id { get; set; }
        String LastName { get; set; }
        String FirstName { get; set; }
        String Mail { get; set; }
        String Adresse { get; set; }
        DateTime Birth { get; set; }
        String PhoneNumber { get; set; }

        Role Role { get; set; }
    }
}