using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using API.Models;
using System;

namespace API.Data
{
    public interface IUsuarioRepository
    {
        Usuario GetUsuario(int usuarioID);
        IList<Usuario> GetUsuarios();
        Usuario AddUsuario(Usuario usuario);
    }


    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationContext contexto) : base(contexto)
        { }

        public Usuario AddUsuario(Usuario usuario)
        {
            try
            {
                usuario.DataDeCadastro = DateTime.Now;
                dbSet.Add(usuario);
                contexto.SaveChanges();
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario GetUsuario(int usuarioID)
        {
            var usuarios = dbSet
                .Include(p =>  p.Nivel)
                .Where(p => p.ID == usuarioID)
                .FirstOrDefault();
            return usuarios;
        }

        public IList<Usuario> GetUsuarios()
        {
            var usuarios = dbSet
              .Include(p => p.Nivel);
            return usuarios.ToList();
        }
    }
}
