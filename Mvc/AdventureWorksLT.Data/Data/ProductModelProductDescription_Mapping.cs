//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksLT.Data.Data
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class ProductModelProductDescription_Mapping : EntityTypeConfiguration<ProductModelProductDescription>
    {
        public ProductModelProductDescription_Mapping()
        {                        
              this.HasKey(t => new {t.ProductModelID, t.ProductDescriptionID, t.Culture});        
              this.ToTable("ProductModelProductDescription", "SalesLT");
              this.Property(t => t.ProductModelID).HasColumnName("ProductModelID").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.ProductDescriptionID).HasColumnName("ProductDescriptionID").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.Culture).HasColumnName("Culture").IsRequired().IsFixedLength().HasMaxLength(6);
              this.Property(t => t.rowguid).HasColumnName("rowguid");
              this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
              this.HasRequired(t => t.ProductDescription).WithMany(t => t.ProductModelProductDescription).HasForeignKey(d => d.ProductDescriptionID);
              this.HasRequired(t => t.ProductModel).WithMany(t => t.ProductModelProductDescription).HasForeignKey(d => d.ProductModelID);
         }
    }
}
