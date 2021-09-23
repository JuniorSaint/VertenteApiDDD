using System;
using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.Client;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Dtos.Phone;
using Api.Domain.Dtos.Product;
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
            #endregion


            #region Client
            CreateMap<ClientModel, ClientDto>().ReverseMap();
            CreateMap<ClientModel, ClientDtoCreate>().ReverseMap();
            CreateMap<ClientModel, ClientDtoUpdate>().ReverseMap();
            #endregion

            #region ImagePaht
            CreateMap<ImagePathModel, ImagePathDto>().ReverseMap();
            CreateMap<ImagePathModel, ImagePathDtoCreate>().ReverseMap();
            CreateMap<ImagePathModel, ImagePathDtoUpdate>().ReverseMap();
            #endregion

            #region Phone
            CreateMap<PhoneModel, PhoneDto>().ReverseMap();
            CreateMap<PhoneModel, PhoneDtoCreate>().ReverseMap();
            CreateMap<PhoneModel, PhoneDtoUpdate>().ReverseMap();
            #endregion

            #region Product
            CreateMap<ProductModel, ProductModel>().ReverseMap();
            CreateMap<ProductModel, ProductDtoCreate>().ReverseMap();
            CreateMap<ProductModel, ProductDtoUpdate>().ReverseMap();
            #endregion

            #region Address
            CreateMap<AddressModel, AddressDto>().ReverseMap();
            CreateMap<AddressModel, AddressDtoCreate>().ReverseMap();
            CreateMap<AddressModel, AddressDtoUpdate>().ReverseMap();
            #endregion

        }
    }
}
