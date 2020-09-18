using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UsuarioConfigs : BaseModel
    {
        //tabela com as configurações de cada usuario
        public int ID { get; set; }
        public Usuario Usuario { get; set; }
        public string PrimeiroDiaDaSemana { get; set; }
        public Decimal AumentarDiminuirMinutos { get; set; }
    }
}
