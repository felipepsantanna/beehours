using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;


namespace API.Data
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected DbSet<T> dbSet { get; set; }

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
