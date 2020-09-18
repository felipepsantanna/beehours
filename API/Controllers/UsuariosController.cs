using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosController(IConfiguration config, IUsuarioRepository usuarioRepository)
        {
            _config = config;
            _usuarioRepository = usuarioRepository;
        }

        // GET usuarios
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_usuarioRepository.GetUsuarios());
        }

        // GET usuarios/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return Json(_usuarioRepository.GetUsuario(id));
        }


        //POST usuario
        [HttpPost]
        public JsonResult Post([FromBody] Usuario value)
        {
            return Json(_usuarioRepository.AddUsuario(value));
        }

    }
}