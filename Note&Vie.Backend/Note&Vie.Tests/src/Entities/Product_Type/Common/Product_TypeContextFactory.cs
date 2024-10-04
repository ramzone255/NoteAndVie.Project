using Microsoft.EntityFrameworkCore;
using Note_Vie.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Tests.src.Entities.Product_Type.Common
{
    public class Product_TypeContextFactory
    {
        public static int id_product_type_for_delete = 3;
        public static int id_product_type_for_update = 4;

        public static Note_VieDbContext Create()
        {
            var options = new DbContextOptionsBuilder<Note_VieDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new Note_VieDbContext(options);
            context.Database.EnsureCreated();
            context.Product_Type.AddRange(
                new Domain.Entities.Product_Type
                {
                    id_product_type = 1,
                    product_type_name = "Name1"
                },

                new Domain.Entities.Product_Type
                {
                    id_product_type = 2,
                    product_type_name = "Name2"
                },

                new Domain.Entities.Product_Type

                {
                    id_product_type = id_product_type_for_delete,
                    product_type_name = "Name3"
                },

                new Domain.Entities.Product_Type
                {
                    id_product_type = id_product_type_for_update,
                    product_type_name = "Name4"
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
