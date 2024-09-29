using Microsoft.EntityFrameworkCore;
using Note_Vie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Interfaces
{
    public interface INote_VieDbContext
    {
        DbSet<Client> Client { get; set; }
        DbSet<Client_Type> Client_Type { get; set; }
        DbSet<Employees> Employees { get; set; }
        DbSet<Post> Post { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<Product_Status> Product_Status { get; set; }
        DbSet<Product_Type> Product_Type { get; set; }
        DbSet<Receipt> Receipt { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
