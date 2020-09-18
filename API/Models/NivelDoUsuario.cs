using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class NivelDoUsuario : BaseModel
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
    }
}
