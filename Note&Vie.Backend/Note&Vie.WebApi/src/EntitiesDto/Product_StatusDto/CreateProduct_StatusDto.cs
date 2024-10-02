using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status;
using System.ComponentModel.DataAnnotations;

namespace Note_Vie.WebApi.src.EntitiesDto.Product_StatusDto
{
    public class CreateProduct_StatusDto : IMapWith<CreateProduct_StatusCommand>
    {
        public string product_status_name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProduct_StatusDto, CreateProduct_StatusCommand>()
                .ForMember(noteCommand => noteCommand.product_status_name,
                opt => opt.MapFrom(noteDto => noteDto.product_status_name));
        }
    }
}
