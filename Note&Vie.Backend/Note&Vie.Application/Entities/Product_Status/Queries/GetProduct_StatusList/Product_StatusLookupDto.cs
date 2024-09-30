using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Vie.Application.Entities.Product_Status.Queries.GetProduct_StatusList
{
    public class Product_StatusLookupDto : IMapWith<Domain.Entities.Product_Status>
    {
        public int id_product_status { get; set; }
        public string product_status_name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Product_Status, Product_StatusLookupDto>()
                .ForMember(noteDto => noteDto.id_product_status,
                opt => opt.MapFrom(note => note.id_product_status))
                .ForMember(noteDto => noteDto.product_status_name,
                opt => opt.MapFrom(note => note.product_status_name));
        }

    }
}
