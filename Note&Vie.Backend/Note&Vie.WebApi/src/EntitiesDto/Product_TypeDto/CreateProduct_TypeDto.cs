using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Entities.Product_Status.Commands.CreateProduct_Status;

namespace Note_Vie.WebApi.src.EntitiesDto.Product_TypeDto
{
    public class CreateProduct_TypeDto : IMapWith<CreateProduct_StatusCommand>
    {
        public string product_type_name {  get; set; }

        public void MAooing(Profile profile)
        {
            profile.CreateMap<CreateProduct_TypeDto, CreateProduct_StatusCommand>()
                .ForMember(noteCommand => noteCommand.product_status_name,
                opt => opt.MapFrom(noteDto => noteDto.product_type_name));
        }
    }
}
