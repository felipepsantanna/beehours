using System;

namespace API.TRACKR.Models
{
    public interface IUsuario
    {
        int AceitouTermosParceiros { get; set; }
        int AceitouTermosUso { get; set; }
        DateTime DataDeCadastro { get; set; }
        string Email { get; set; }
        int ID { get; set; }
        NivelDoUsuario Nivel { get; set; }
        string Nome { get; set; }
        int Pais { get; set; }
        string Password { get; set; }
        string Profissao { get; set; }
    }


}