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
    
    internal partial class CustomerAddress_Mapping : EntityTypeConfiguration<CustomerAddress>
    {
        public CustomerAddress_Mapping()
        {                        
              this.HasKey(t => new {t.CustomerID, t.AddressID});        
              this.ToTable("CustomerAddress", "SalesLT");
              this.Property(t => t.CustomerID).HasColumnName("CustomerID").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.AddressID).HasColumnName("AddressID").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.AddressType).HasColumnName("AddressType").IsRequired().HasMaxLength(50);
              this.Property(t => t.rowguid).HasColumnName("rowguid");
              this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
              this.HasRequired(t => t.Address).WithMany(t => t.CustomerAddress).HasForeignKey(d => d.AddressID);
              this.HasRequired(t => t.Customer).WithMany(t => t.CustomerAddress).HasForeignKey(d => d.CustomerID);
         }
    }
}
