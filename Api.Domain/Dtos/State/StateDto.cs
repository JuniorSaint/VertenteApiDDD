using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.State
{
    public class StateDto
    {
        public Guid Id { get; set; }

        public string Sigla { get; set; }

        public String StateName { get; set; }
    }
}
