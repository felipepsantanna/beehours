using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NivelDoUsuario>().HasKey(n => n.ID);

            modelBuilder.Entity<Usuario>().HasKey(u => u.ID);
            modelBuilder.Entity<Usuario>().HasOne(u => u.Nivel);

            modelBuilder.Entity<Models.UsuarioConfigs>().HasKey(uc => uc.ID);
            modelBuilder.Entity<Models.UsuarioConfigs>().HasOne(uc => uc.Usuario);

            modelBuilder.Entity<Time>().HasKey(t => t.ID);
            modelBuilder.Entity<CargoDoTime>().HasKey(c => c.ID);

            modelBuilder.Entity<MembrosDoTime>().HasKey(mt => new { mt.IDTime, mt.IDUsuario });
            modelBuilder.Entity<MembrosDoTime>().HasOne(mt => mt.Cargo);

            modelBuilder.Entity<Tarefa>().HasKey(t => t.ID);
            modelBuilder.Entity<Projeto>().HasKey(t => t.ID);
            modelBuilder.Entity<Projeto>().HasMany<Tarefa>("Tarefas");

            modelBuilder.Entity<HorasTrabalhadas>().HasKey(h => h.ID);
            modelBuilder.Entity<HorasTrabalhadas>().HasOne(h => h.Projeto);
            modelBuilder.Entity<HorasTrabalhadas>().HasOne(h => h.Tarefa);
            modelBuilder.Entity<HorasTrabalhadas>().HasOne(h => h.Usuario);

            

        }
    }
}
