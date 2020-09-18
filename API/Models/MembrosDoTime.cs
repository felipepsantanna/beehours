using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class MembrosDoTime : BaseModel
    {
        public int IDUsuario { get; set; }
        public int IDTime { get; set; }
        public CargoDoTime Cargo { get; set; }
    }
}
