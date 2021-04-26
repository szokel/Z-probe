using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AssoTabM.Model
{
    public partial class ColorContext : DbContext
    {
        public ColorContext()
        {
        }

        public ColorContext(DbContextOptions<ColorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<ProductSchema> ProductSchemas { get; set; }
        public virtual DbSet<ProductSchemaColorAssoc> ProductSchemaColorAssocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\DEV2019;Initial Catalog=szin2;Trusted_Connection=True;");
            }
        }

    }
}
