using Note_Vie.Application.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note_Vie.Domain;
using AutoMapper;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusDetails
{
    public class Product_StatusDetailsVm : IMapWith<Domain.Entities.Product_Status>
    {
        public int id_product_status { get; set; }
        public string product_status_name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Product_Status, Product_StatusDetailsVm>()
                .ForMember(noteVm => noteVm.id_product_status,
                opt => opt.MapFrom(note => note.id_product_status))
                .ForMember(noteVm => noteVm.product_status_name,
                opt => opt.MapFrom(note => note.product_status_name));
        }
    }
}
