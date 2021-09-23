﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.Phone;

namespace Api.Domain.Dtos.Client
{
    public class ClientDtoUpdate
    {
        [Required(ErrorMessage = "Campo Id é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Cnpj/Cpf é campo obrigatório")]
        public int Cpf_Cnpj { get; set; }

        [EmailAddress(ErrorMessage = "Campo email com formato inválido")]
        public string Email { get; set; }

        public string Note { get; set; }

        public IEnumerable<PhoneDto> Phones { get; set; }

        public IEnumerable<AddressDto> Addresses { get; set; }
    }
}