using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.User;
using Api.Domain.Dtos.Client;
using Api.Domain.Entities;
using AutoMapper;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Dtos.Phone;
using Api.Domain.Dtos.Product;
using Api.Domain.Dtos.State;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            #region User Dto
            CreateMap<UserDto, AddressEntity>().ReverseMap();
            CreateMap<UserDtoCreate, AddressEntity>().ReverseMap();
            CreateMap<UserDtoUpdate, AddressEntity>().ReverseMap();
            #endregion

            #region Address Dto
            CreateMap<AddressDto, AddressEntity>().ReverseMap();
            CreateMap<AddressDtoCreate, AddressEntity>().ReverseMap();
            CreateMap<AddressDtoUpdate, AddressEntity>().ReverseMap();
            #endregion

            #region Client Dto
            CreateMap<ClientDto, ClientEntity>().ReverseMap();
            CreateMap<ClientDtoCreate, ClientEntity>().ReverseMap();
            CreateMap<ClientDtoCreateResult, ClientEntity>().ReverseMap();
            CreateMap<ClientDtoUpdate, ClientEntity>().ReverseMap();
            CreateMap<ClientDtoUpdateResult, ClientEntity>().ReverseMap();
            #endregion

            #region ImagePath Dto
            CreateMap<ImagePathDto, ImagePathEntity>().ReverseMap();
            CreateMap<ImagePathDtoCreate, ImagePathEntity>().ReverseMap();
            CreateMap<ImagePathDtoUpdate, ImagePathEntity>().ReverseMap();
            #endregion

            #region Phone Dto
            CreateMap<PhoneDto, PhoneEntity>().ReverseMap();
            CreateMap<PhoneDtoCreate, PhoneEntity>().ReverseMap();
            CreateMap<PhoneDtoUpdate, PhoneEntity>().ReverseMap();
            #endregion

            #region Product
            CreateMap<ProductDto, ProductEntity>().ReverseMap();
            CreateMap<ProductDtoCreate, ProductEntity>().ReverseMap();
            CreateMap<ProductDtoUpdate, ProductEntity>().ReverseMap();
            #endregion

            #region State
            CreateMap<StateDto, StatesEntity>();
            #endregion
        }
    }
}
