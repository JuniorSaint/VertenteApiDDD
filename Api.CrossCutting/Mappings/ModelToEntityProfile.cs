using Api.Domain.Models;
using AutoMapper;
using Api.Domain.Entities;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<AddressEntity, AddressModel>().ReverseMap();
            CreateMap<ClientEntity, ClientModel>().ReverseMap();
            CreateMap<ImagePathEntity, ImagePathModel>().ReverseMap();
            CreateMap<PhoneEntity, PhoneModel>().ReverseMap();
            CreateMap<ProductEntity, ProductModel>().ReverseMap();
            CreateMap<StatesEntity, StateModel>().ReverseMap();
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}
