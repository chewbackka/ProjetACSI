namespace RacletteProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UtilisateurModel : DbContext
    {
        public UtilisateurModel()
            : base("name=UtilisateurModel")
        {
        }

        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.firstNameUtilisateur)
                .IsUnicode(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.lastNameUtilisateur)
                .IsUnicode(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.mailUtilisateur)
                .IsUnicode(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.adresseUtilisateur)
                .IsUnicode(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.callNumberUtilisateur)
                .IsUnicode(false);
        }
    }
}
