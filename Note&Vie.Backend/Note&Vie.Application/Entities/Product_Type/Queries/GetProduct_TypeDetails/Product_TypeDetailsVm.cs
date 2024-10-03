using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Type.Queries.GetProduct_TypeDetails
{
    public class Product_TypeDetailsVm : IMapWith<Domain.Entities.Product_Type>
    {
        public int id_product_type {  get; set; }
        public string product_type_name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Product_Type, Product_TypeDetailsVm>()
                .ForMember(noteVm => noteVm.id_product_type,
                opt => opt.MapFrom(note => note.id_product_type))
                .ForMember(noteVm => noteVm.product_type_name,
                opt => opt.MapFrom(note => note.product_type_name));
        }
    }
}
