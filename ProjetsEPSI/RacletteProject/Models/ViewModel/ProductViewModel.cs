using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RacletteProject.Models.ViewModel
{
    public class ProductViewModel : Product
    {
        public ProductViewModel () {
            ProductId = base.idProduct;
            ProductLabel = base.labelProduct;
            ProductDesc = base.descProduct;
            ProductPrice = base.priceProduct;
            CategorieId = base.idCategorie;

        }

        private int ProductId { get; set; }

        private string ProductLabel { get; set; }

        private string ProductDesc { get; set; }

        private double? ProductPrice { get; set; }

        private int? CategorieId { get; set; }

        private Categorie = 
    }
}