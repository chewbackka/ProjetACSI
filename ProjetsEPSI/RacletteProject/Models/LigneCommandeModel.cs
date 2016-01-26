namespace RacletteProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LigneCommandeModel : DbContext
    {
        public LigneCommandeModel()
            : base("name=LigneCommandeModel")
        {
        }

        public virtual DbSet<LigneCommande> LigneCommande { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
