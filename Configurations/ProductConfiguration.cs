﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;


namespace shopapp.data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.ProductId);
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.DateAdded).HasDefaultValueSql("date('now')"); //Sqlite
            //builder.Property(m => m.DateAdded).HasDefaultValueSql("getdate()"); //MsSQL
        }
    }
}
