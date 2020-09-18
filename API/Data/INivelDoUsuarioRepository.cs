using System.Collections.Generic;
using System.Linq;
using API.Models;

namespace API.Data
{
    public interface INivelDoUsuarioRepository
    {
        void SaveNiveis(List<NivelDoUsuario> _niveis);
        IList<NivelDoUsuario> Niveis();
    }


    public class NivelDoUsuarioRepository : BaseRepository<NivelDoUsuario>, INivelDoUsuarioRepository
    {
        public NivelDoUsuarioRepository(ApplicationContext contexto) : base(contexto)
        {
            
        }

        public IList<NivelDoUsuario> Niveis()
        {
            return dbSet.ToList();
        }

        public void SaveNiveis(List<NivelDoUsuario> _niveis)
        {
            foreach (var nivel in _niveis)
            {

                if (!dbSet.Where(p => p.ID == nivel.ID).Any())
                {
                    dbSet.Add(nivel);
                }
            }
            contexto.SaveChanges();
        }
    }
}
