namespace RacletteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int idProduct { get; set; }

        [StringLength(45)]
        public string labelProduct { get; set; }

        [StringLength(255)]
        public string descProduct { get; set; }

        public double? priceProduct { get; set; }

        public int? idCategorie { get; set; }
    }
}
