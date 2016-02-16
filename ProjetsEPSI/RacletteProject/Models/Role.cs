using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RacletteProject.Domain
{
    public class Role
    {
        Guid Id { get; set; }
        String Label { get; set; }

        IList<User> Users { get; set; }
    }
}