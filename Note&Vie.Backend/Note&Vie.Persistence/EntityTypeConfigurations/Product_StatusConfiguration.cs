using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Note_Vie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Persistence.EntityTypeConfigurations
{
    public class Product_StatusConfiguration : IEntityTypeConfiguration<Product_Status>
    {
        public void Configure(EntityTypeBuilder<Product_Status> builder)
        {
            builder.HasKey(note => note.id_product_status);
            builder.HasIndex(note => note.id_product_status).IsUnique();
            builder.Property(note => note.product_status_name).HasMaxLength(50).IsRequired();
        }
    }
}
