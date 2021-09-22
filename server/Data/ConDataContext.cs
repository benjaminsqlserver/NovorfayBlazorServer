using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using NovorfayProductCatalogue.Models.ConData;

namespace NovorfayProductCatalogue.Data
{
  public partial class ConDataContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ConDataContext(DbContextOptions<ConDataContext> options):base(options)
    {
    }

    public ConDataContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<NovorfayProductCatalogue.Models.ConData.Product>()
              .HasOne(i => i.ProductCategory)
              .WithMany(i => i.Products)
              .HasForeignKey(i => i.CategoryID)
              .HasPrincipalKey(i => i.CategoryID);


        builder.Entity<NovorfayProductCatalogue.Models.ConData.Product>()
              .Property(p => p.ProductID)
              .HasPrecision(19, 0);

        builder.Entity<NovorfayProductCatalogue.Models.ConData.Product>()
              .Property(p => p.CategoryID)
              .HasPrecision(10, 0);

        builder.Entity<NovorfayProductCatalogue.Models.ConData.Product>()
              .Property(p => p.Price)
              .HasPrecision(18, 2);

        builder.Entity<NovorfayProductCatalogue.Models.ConData.ProductCategory>()
              .Property(p => p.CategoryID)
              .HasPrecision(10, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<NovorfayProductCatalogue.Models.ConData.Product> Products
    {
      get;
      set;
    }

    public DbSet<NovorfayProductCatalogue.Models.ConData.ProductCategory> ProductCategories
    {
      get;
      set;
    }
  }
}
