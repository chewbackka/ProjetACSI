namespace RacletteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande")]
    public partial class Commande
    {
        [Key]
        public int idCommande { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCommande { get; set; }

        public int? id_Utilisateur { get; set; }
    }
}
