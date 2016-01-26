namespace RacletteProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RoleModel : DbContext
    {
        public RoleModel()
            : base("name=RoleModel")
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.labelProduct)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.descProduct)
                .IsUnicode(false);
        }
    }
}
