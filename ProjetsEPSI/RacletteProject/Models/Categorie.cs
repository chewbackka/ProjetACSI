namespace RacletteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categorie")]
    public partial class Categorie
    {
        [Key]
        public int idCategorie { get; set; }

        [StringLength(45)]
        public string labelCategorie { get; set; }
    }
}
