namespace InventoryManagement
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

        public virtual DbSet<tblLocation> tblLocations { get; set; }
        public virtual DbSet<tblLotNum> tblLotNums { get; set; }
        public virtual DbSet<tblLotqty> tblLotqties { get; set; }
        public virtual DbSet<tblPartNum> tblPartNums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblLocation>()
                .Property(e => e.a_location)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotNum>()
                .Property(e => e.lotnum)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotNum>()
                .Property(e => e.lotnote)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotNum>()
                .Property(e => e.lotuam)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotNum>()
                .Property(e => e.partDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotNum>()
                .Property(e => e.partCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblLotNum>()
                .Property(e => e.lotComments)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotNum>()
                .HasMany(e => e.tblLotqties)
                .WithRequired(e => e.tblLotNum)
                .HasForeignKey(e => e.lotID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblLotqty>()
                .Property(e => e.Reason_for_change)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotqty>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotqty>()
                .Property(e => e.a_location)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotqty>()
                .Property(e => e.StatusOfitem)
                .IsUnicode(false);

            modelBuilder.Entity<tblLotqty>()
                .Property(e => e.Purchase_Order)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartNum>()
                .Property(e => e.partnum)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartNum>()
                .Property(e => e.partdesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartNum>()
                .Property(e => e.partnote)
                .IsUnicode(false);

            modelBuilder.Entity<tblPartNum>()
                .HasMany(e => e.tblLotNums)
                .WithRequired(e => e.tblPartNum)
                .HasForeignKey(e => e.partID)
                .WillCascadeOnDelete(false);
        }
    }
}
