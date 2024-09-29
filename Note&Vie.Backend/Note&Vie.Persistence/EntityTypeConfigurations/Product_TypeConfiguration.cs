using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Note_Vie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Persistence.EntityTypeConfigurations
{
    public class Product_TypeConfiguration : IEntityTypeConfiguration<Product_Type>
    {
        public void Configure(EntityTypeBuilder<Product_Type> builder)
        {
            builder.HasKey(note => note.id_product_type);
            builder.HasIndex(note => note.id_product_type).IsUnique();
            builder.Property(note => note.product_type_name).HasMaxLength(50).IsRequired();
        }
    }
}
