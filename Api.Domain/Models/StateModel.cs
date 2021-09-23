using System;
namespace Api.Domain.Models
{
    public class StateModel : BaseModel
    {
        private string _sigla;
        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        private object _stateName;
        public object StateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }
    }
}
