namespace RacletteProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CommandeModel : DbContext
    {
        public CommandeModel()
            : base("name=CommandeModel")
        {
        }

        public virtual DbSet<Commande> Commande { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
