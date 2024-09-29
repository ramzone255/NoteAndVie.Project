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
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.HasKey(note => note.id_employees);
            builder.HasIndex(note => note.id_employees).IsUnique();
            builder.Property(note => note.employees_name).HasMaxLength(50).IsRequired();
            builder.Property(note => note.login).HasMaxLength(50).IsRequired();
            builder.Property(note => note.password).HasMaxLength(50).IsRequired();
            builder.Property(note => note.id_post).IsRequired();
        }
    }
}
