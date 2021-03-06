using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.Client;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Dtos.Phone;
using Api.Domain.Dtos.Product;
using Api.Domain.Dtos.ProductType;
using Api.Domain.Dtos.State;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {

            #region User
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
            CreateMap<UserModel, UserDtoCreateResult>().ReverseMap();
            #endregion


            #region Client
            CreateMap<ClientModel, ClientDto>().ReverseMap();
            CreateMap<ClientModel, ClientDtoCreate>().ReverseMap();
            CreateMap<ClientModel, ClientDtoUpdate>().ReverseMap();
            CreateMap<ClientModel, ClientDtoUpdateResult>().ReverseMap();
            #endregion

            #region ImagePath
            CreateMap<ImagePathModel, ImagePathDto>().ReverseMap();
            CreateMap<ImagePathModel, ImagePathDtoCreate>().ReverseMap();
            CreateMap<ImagePathModel, ImagePathDtoUpdate>().ReverseMap();
            #endregion

            #region Phone
            CreateMap<PhoneModel, PhoneDto>().ReverseMap();
            CreateMap<PhoneModel, PhoneDtoCreate>().ReverseMap();
            CreateMap<PhoneModel, PhoneDtoUpdate>().ReverseMap();
            CreateMap<PhoneModel, PhoneUpdateDtoResult>().ReverseMap();
            #endregion

            #region Product
            CreateMap<ProductModel, ProductModel>().ReverseMap();
            CreateMap<ProductModel, ProductDtoCreate>().ReverseMap();
            CreateMap<ProductModel, ProductDtoUpdate>().ReverseMap();
            CreateMap<ProductModel, ProductUpdateDtoResult>().ReverseMap();
            #endregion

            #region Address
            CreateMap<AddressModel, AddressDto>().ReverseMap();
            CreateMap<AddressModel, AddressDtoCreate>().ReverseMap();
            CreateMap<AddressModel, AddressDtoUpdate>().ReverseMap();
            #endregion

            #region ProductType
            CreateMap<ProductTypeModel, ProductTypeDto>().ReverseMap();
            CreateMap<ProductTypeModel, ProductTypeCreateDto>().ReverseMap();
            CreateMap<ProductTypeModel, ProductTypeUpdateDto>().ReverseMap();
            CreateMap<ProductTypeModel, ProductTypeUpdateDtoResult>().ReverseMap();
            #endregion

            #region State
            CreateMap<StateModel, StateDto>().ReverseMap();
            #endregion

        }
    }
}
