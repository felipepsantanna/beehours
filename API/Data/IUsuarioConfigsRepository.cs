using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using API.Models;
using System;

namespace API.Data
{
    public interface IUsuarioConfigsRepository
    {
        UsuarioConfigs GetConfig(int usuarioID);
        UsuarioConfigs AddConfig(UsuarioConfigs config);
        UsuarioConfigs UpdateConfig(UsuarioConfigs config);
    }

    public class UsuarioConfigsRepository : BaseRepository<UsuarioConfigs>, IUsuarioConfigsRepository
    {
        public UsuarioConfigsRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public UsuarioConfigs AddConfig(UsuarioConfigs config)
        {
            try
            {
                dbSet.Add(config);
                contexto.SaveChanges();
                return config;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioConfigs GetConfig(int usuarioID)
        {
            try
            {
                var config = dbSet
                .Include(p => p.Usuario)
                .Where(p => p.Usuario.ID == usuarioID)
                .FirstOrDefault();
                return config;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioConfigs UpdateConfig(UsuarioConfigs config)
        {
            try
            {
                dbSet.Update(config);
                contexto.SaveChanges();
                return config;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
