using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface IProjetoReporitory
    {
        Projeto GetProjeto(int projetoID);
        IList<Projeto> GetProjetos();
        Projeto AddProjeto(Projeto projeto);
    }

    public class ProjetoReporitory : BaseRepository<Projeto>, IProjetoReporitory
    {
        public ProjetoReporitory(ApplicationContext contexto) : base(contexto)
        {
        }

        public Projeto AddProjeto(Projeto projeto)
        {
            throw new NotImplementedException();
        }

        public Projeto GetProjeto(int projetoID)
        {
            throw new NotImplementedException();
        }

        public IList<Projeto> GetProjetos()
        {
            throw new NotImplementedException();
        }
    }
}
