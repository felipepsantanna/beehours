using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Projeto : BaseModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public string Notas { get; set; }
        public bool Aprovacao { get; set; }
        public List<Tarefa> Tarefas;

    }

    public class Tarefa : BaseModel
    {
        public int ID { get; set; }
        public int Nome { get; set; }
        public List<Projeto> Projeto;
    }
}
