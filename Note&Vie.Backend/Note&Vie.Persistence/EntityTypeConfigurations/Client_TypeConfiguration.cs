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
    public class Client_TypeConfiguration : IEntityTypeConfiguration<Client_Type>
    {
        public void Configure(EntityTypeBuilder<Client_Type> builder)
        {
            builder.HasKey(note => note.id_client_type);
            builder.HasIndex(note => note.id_client_type).IsUnique();
            builder.Property(note => note.discount).IsRequired();
            builder.Property(note => note.client_type_name).HasMaxLength(50).IsRequired();
        }
    }
}
