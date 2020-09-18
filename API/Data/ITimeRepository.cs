using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using API.Models;
using System;

namespace API.Data
{
    public interface ITimeRepository
    {
        IList<Time> GetTimes();
        Time GetTime(int timeID);
        Time AddTime(Time time);
    }

    public class TimeRepository : BaseRepository<Time>, ITimeRepository
    {
        public TimeRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Time AddTime(Time time)
        {
            try
            {
                dbSet.Add(time);
                contexto.SaveChanges();
                return time;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Time GetTime(int timeID)
        {
            var time = dbSet
                .Where(p => p.ID == timeID)
                .FirstOrDefault();
            return time;
        }

        public IList<Time> GetTimes()
        {
            var times = dbSet
                .ToList();
            return times;
        }
    }
}
