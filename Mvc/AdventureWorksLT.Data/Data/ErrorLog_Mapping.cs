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
    
    internal partial class ErrorLog_Mapping : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLog_Mapping()
        {                        
              this.HasKey(t => t.ErrorLogID);        
              this.ToTable("ErrorLog");
              this.Property(t => t.ErrorLogID).HasColumnName("ErrorLogID");
              this.Property(t => t.ErrorTime).HasColumnName("ErrorTime");
              this.Property(t => t.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(128);
              this.Property(t => t.ErrorNumber).HasColumnName("ErrorNumber");
              this.Property(t => t.ErrorSeverity).HasColumnName("ErrorSeverity");
              this.Property(t => t.ErrorState).HasColumnName("ErrorState");
              this.Property(t => t.ErrorProcedure).HasColumnName("ErrorProcedure").HasMaxLength(126);
              this.Property(t => t.ErrorLine).HasColumnName("ErrorLine");
              this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage").IsRequired().HasMaxLength(4000);
         }
    }
}