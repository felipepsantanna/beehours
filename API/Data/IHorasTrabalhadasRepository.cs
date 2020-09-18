using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using API.Models;
using System;

namespace API.Data
{
    public interface IHorasTrabalhadasRepository
    {
        HorasTrabalhadas AddHoras(HorasTrabalhadas hora);
        IList<HorasTrabalhadas> GetHorasByUser(int usuarioID);
        IList<HorasTrabalhadas> GetHorasByDate(DateTime dia);
        IList<HorasTrabalhadas> GetHorasByDateAndUser(DateTime dia, int usuarioID);
    }
    //ESTÁ COM ERROS DE CONVERSÃO
    public class HorasTrabalhadasRepository : BaseRepository<HorasTrabalhadas>, IHorasTrabalhadasRepository
    {
        public HorasTrabalhadasRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public HorasTrabalhadas AddHoras(HorasTrabalhadas hora)
        {
            dbSet.Add(hora);
            var id = contexto.SaveChanges();
            return dbSet.Where(p => p.ID == id).FirstOrDefault();
        }

        public IList<HorasTrabalhadas> GetHorasByDate(DateTime dia)
        {
            var horas = dbSet
               .Include(h => h.Projeto)
               .Include(h => h.Tarefa)
               .Include(h => h.Usuario)
               .Where(h => h.dataDeInicio == dia).ToList();

            return horas;
        }

        public IList<HorasTrabalhadas> GetHorasByDateAndUser(DateTime dia, int usuarioID)
        {
            var horas = dbSet
               .Include(h => h.Projeto)
               .Include(h => h.Tarefa)
               .Include(h => h.Usuario)
               .Where(h => h.dataDeInicio == dia && h.Usuario.ID == usuarioID).ToList();

            return horas;
        }

        public IList<HorasTrabalhadas> GetHorasByUser(int usuarioID)
        {
            var horas = dbSet
               .Include(h => h.Projeto)
               .Include(h => h.Tarefa)
               .Include(h => h.Usuario)
               .Where(h => h.Usuario.ID == usuarioID).ToList();

            return horas;
        }
    }
}
