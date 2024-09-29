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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(note => note.id_client);
            builder.HasIndex(note => note.id_client).IsUnique();
            builder.Property(note => note.client_name).HasMaxLength(50).IsRequired();
            builder.Property(note => note.client_mail).HasMaxLength(50).IsRequired();
            builder.Property(note => note.id_client_type).IsRequired();
        }
    }
}
