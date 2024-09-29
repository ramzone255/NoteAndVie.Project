using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note_Vie.Domain;
using Note_Vie.Application;
using Microsoft.EntityFrameworkCore;
using Note_Vie.Application.Interfaces;
using Note_Vie.Domain.Entities;
using Note_Vie.Persistence.EntityTypeConfigurations;
using System.Reflection;

namespace Note_Vie.Persistence.Data
{
    public class Note_VieDbContext : DbContext, INote_VieDbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Client_Type> Client_Type { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Product_Status> Product_Status { get; set; }
        public DbSet<Product_Type> Product_Type { get; set; }
        public DbSet<Receipt> Receipt { get; set; }

        public Note_VieDbContext(DbContextOptions<Note_VieDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new Product_TypeConfiguration());
            builder.ApplyConfiguration(new Product_StatusConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ReceiptConfiguration());
            builder.ApplyConfiguration(new PostConfiguration());
            builder.ApplyConfiguration(new EmployeesConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new Client_TypeConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
