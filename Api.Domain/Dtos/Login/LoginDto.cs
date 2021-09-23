﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Login
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é um campo obrigatório para Login")]
        public string Password { get; set; }
    }
}