using Microsoft.EntityFrameworkCore;
using Note_Vie.Domain.Entities;
using Note_Vie.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Status.Common
{
    public class Product_StatusContextFactory
    {
        public static int id_product_status_for_delete = 3;
        public static int id_product_status_for_update = 4;

        public static Note_VieDbContext Create()
        {
            var options = new DbContextOptionsBuilder<Note_VieDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new Note_VieDbContext(options);
            context.Database.EnsureCreated();
            context.Product_Status.AddRange(
                new Domain.Entities.Product_Status
                {
                    id_product_status = 1,
                    product_status_name = "Name1"
                },

                new Domain.Entities.Product_Status
                {
                    id_product_status = 2,
                    product_status_name = "Name2"
                },

                new Domain.Entities.Product_Status

                {
                    id_product_status = id_product_status_for_delete,
                    product_status_name = "Name3"
                },

                new Domain.Entities.Product_Status
                {
                    id_product_status = id_product_status_for_update,
                    product_status_name = "Name4"
                }
            );
            context.SaveChanges();
            return context;
        }

        public static void Destroy(Note_VieDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
