using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface ITarefaRepository
    {
        Tarefa GetTarefa(int tarefaID);
        IList<Tarefa> GetTarefas();
        Tarefa AddTarefa(Tarefa tarefa);
    }

    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Tarefa AddTarefa(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public Tarefa GetTarefa(int tarefaID)
        {
            throw new NotImplementedException();
        }

        public IList<Tarefa> GetTarefas()
        {
            throw new NotImplementedException();
        }
    }
}
