using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status;
using Note_Vie.Application.Entities.Product_Type.Commands.UpdateProduct_Type;
using Note_Vie.WebApi.src.EntitiesDto.Product_StatusDto;

namespace Note_Vie.WebApi.src.EntitiesDto.Product_TypeDto
{
    public class UpdateProduct_TypeDto : IMapWith<UpdateProduct_TypeCommand>
    {
        public int id_product_type {  get; set; }
        public string product_type_name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateProduct_TypeDto, UpdateProduct_TypeCommand>()
                .ForMember(noteCommand => noteCommand.id_product_type,
                opt => opt.MapFrom(noteDto => noteDto.id_product_type))
                .ForMember(noteCommand => noteCommand.product_type_name,
                opt => opt.MapFrom(noteDto => noteDto.product_type_name));
        }
    }
}
