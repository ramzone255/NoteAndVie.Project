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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(note => note.id_product);
            builder.HasIndex(note => note.id_product).IsUnique();
            builder.Property(note => note.product_name).HasMaxLength(50).IsRequired();
            builder.Property(note => note.product_description).HasMaxLength(250).IsRequired();
            builder.Property(note => note.product_price).IsRequired();
            builder.Property(note => note.product_image);
            builder.Property(note => note.id_product_status).IsRequired();
            builder.Property(note => note.id_product_type).IsRequired();
        }
    }
}
