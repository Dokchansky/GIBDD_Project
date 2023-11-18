using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GIBDD.Infrastructure
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<BrandEntity> Brands { get; set; }
        public virtual DbSet<CarСategoryEntity> CarСategories { get; set; }
        public virtual DbSet<FineEntity> Fines { get; set; }
        public virtual DbSet<GIBDDEntity> GIBDDs { get; set; }
        public virtual DbSet<ModelEntity> Models { get; set; }
        public virtual DbSet<RoleEntity> Roles { get; set; }
        public virtual DbSet<TransportEntity> Transports { get; set; }
        public virtual DbSet<TypeFineEntity> TypeFines { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandEntity>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.Brand)
                .HasForeignKey(e => e.BrandID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarСategoryEntity>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.CarСategory)
                .HasForeignKey(e => e.CarCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModelEntity>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.Model)
                .HasForeignKey(e => e.ModelID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleEntity>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportEntity>()
                .HasMany(e => e.Fine)
                .WithRequired(e => e.Transport)
                .HasForeignKey(e => e.TransportID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeFineEntity>()
                .HasMany(e => e.Fine)
                .WithRequired(e => e.TypeFine)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEntity>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
