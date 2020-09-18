using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Time : BaseModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Endereco { get; set; }
        public string Logo { get; set; }
    }
}
