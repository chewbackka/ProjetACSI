namespace RacletteProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CategorieModel : DbContext
    {
        public CategorieModel()
            : base("name=CategorieModel")
        {
        }

        public virtual DbSet<Categorie> Categorie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>()
                .Property(e => e.labelCategorie)
                .IsUnicode(false);
        }
    }
}
