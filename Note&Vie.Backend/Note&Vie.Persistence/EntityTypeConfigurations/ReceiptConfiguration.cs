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
    public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.HasKey(note => note.id_receipt);
            builder.HasIndex(note => note.id_receipt).IsUnique();
            builder.Property(note => note.id_employees).IsRequired();
            builder.Property(note => note.id_client).IsRequired();
            builder.Property(note => note.id_product).IsRequired();
        }
    }
}
