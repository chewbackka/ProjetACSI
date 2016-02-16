namespace RacletteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LigneCommande")]
    public partial class LigneCommande
    {
        [Key]
        public int idLigneCommande { get; set; }

        public int? Quantite { get; set; }

        public int? id_Produit { get; set; }

        public int? id_Commande { get; set; }

        public Commande Commande { get; set; }

    }
}
