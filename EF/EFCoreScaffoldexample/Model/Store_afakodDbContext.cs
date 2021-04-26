using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Store_afakodDbContext : DbContext
    {
        public Store_afakodDbContext()
        {
        }

        public Store_afakodDbContext(DbContextOptions<Store_afakodDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<afakod> afakods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\DEV2019;Initial Catalog=StoreWeb@data;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hungarian_CI_AS");

            modelBuilder.Entity<afakod>(entity =>
            {
                entity.ToTable("afakod");

                entity.HasIndex(e => e.nev, "AK_dbo_afakod$nev")
                    .IsUnique();

                entity.Property(e => e.afa_sztt).HasColumnType("decimal(22, 7)");

                entity.Property(e => e.fksz_fizetendo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.fksz_vissza)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.leiras).HasMaxLength(1000);

                entity.Property(e => e.nev)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.rogzites_idopontja).HasDefaultValueSql("(sysdatetime())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
