namespace WebApplication2.Views.Shared
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.streetNo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.postalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.phoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
