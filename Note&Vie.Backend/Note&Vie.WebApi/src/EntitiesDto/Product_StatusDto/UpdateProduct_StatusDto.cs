using AutoMapper;
using Note_Vie.Application.Common.Mapping;
using Note_Vie.Application.Entities.Product_Status.Commands.UpdateProduct_Status;

namespace Note_Vie.WebApi.src.EntitiesDto.Product_StatusDto
{
    public class UpdateProduct_StatusDto : IMapWith<UpdateProduct_StatusCommand>
    {
        public int id_product_status {  get; set; }
        public string product_status_name {  get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateProduct_StatusDto, UpdateProduct_StatusCommand>()
                .ForMember(noteCommand => noteCommand.id_product_status,
                opt => opt.MapFrom(noteDto => noteDto.id_product_status))
                .ForMember(noteCommand => noteCommand.product_status_name,
                opt => opt.MapFrom(noteDto => noteDto.product_status_name));
        }
    }
}
