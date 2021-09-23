using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.State
{
    public class StateDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(2)]
        public string Sigla { get; set; }

        [Required]
        [MaxLength(45)]
        public String StateName { get; set; }
    }
}
