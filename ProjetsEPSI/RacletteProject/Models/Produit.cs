using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RacletteProject.Domain
{
    public class Produit
    {
        Guid Id { get; set; }
        String Label { get; set; }
        float Price { get; set; }

    }
}