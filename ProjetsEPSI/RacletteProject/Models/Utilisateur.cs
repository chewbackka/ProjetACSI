namespace RacletteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utilisateur")]
    public partial class Utilisateur
    {
        [Key]
        public int idUtilisateur { get; set; }

        [StringLength(45)]
        public string login { get; set; }

        [StringLength(45)]
        public string password { get; set; }

        [StringLength(45)]
        public string firstNameUtilisateur { get; set; }

        [StringLength(45)]
        public string lastNameUtilisateur { get; set; }

        [StringLength(45)]
        public string mailUtilisateur { get; set; }

        [StringLength(45)]
        public string adresseUtilisateur { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthUtilisateur { get; set; }

        [StringLength(45)]
        public string callNumberUtilisateur { get; set; }

        public int? id_Role { get; set; }
    }
}
