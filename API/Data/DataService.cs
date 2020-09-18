using API.Data;
using API.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace API.Data
{
    public partial class Startup
    {
        public class DataService : IDataService
        {
            private readonly ApplicationContext contexto;
            private readonly INivelDoUsuarioRepository nivelDoUsuarioRepository;

            public DataService(ApplicationContext contexto, INivelDoUsuarioRepository nivelDoUsuarioRepository)
            {
                this.contexto = contexto;
                this.nivelDoUsuarioRepository = nivelDoUsuarioRepository;
            }

            public void IncializaDB()
            {
                contexto.Database.EnsureCreated();

                List<NivelDoUsuario> _niveis = Niveis();

                nivelDoUsuarioRepository.SaveNiveis(_niveis);
            }

            public static List<NivelDoUsuario> Niveis()
            {
                List<NivelDoUsuario> _niveis = new List<NivelDoUsuario>();

                NivelDoUsuario nivel = new NivelDoUsuario();
                nivel.ID = 1;
                nivel.Descricao = "Admin";
                _niveis.Add(nivel);

                nivel = new NivelDoUsuario();
                nivel.ID = 2;
                nivel.Descricao = "Colaborador";
                _niveis.Add(nivel);

                nivel = new NivelDoUsuario();
                nivel.ID = 3;
                nivel.Descricao = "Gestor";
                _niveis.Add(nivel);

                return _niveis;
            }
        }
    }
}
