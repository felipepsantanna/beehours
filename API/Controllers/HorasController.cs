using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HorasController : Controller
    {

        private readonly IConfiguration _config;
        private readonly IHorasTrabalhadasRepository _horasTrabalhadasRepository;
        public HorasController(IConfiguration config, IHorasTrabalhadasRepository usuarioRepository)
        {
            _config = config;
            _horasTrabalhadasRepository = usuarioRepository;
        }

        // GET horas
        [HttpGet]
        public JsonResult Get(string dia, string usuarioID)
        {
            DateTime _dia;
            ErrorMessage<string> error = new ErrorMessage<string>();
            bool dataConvertida = DateTime.TryParse(dia, out _dia);


            if (!dataConvertida)
            {
                error.status = false;
                error.Message = "Formato de data Invalida!";
                return Json(error);
            }


            if(!string.IsNullOrEmpty(usuarioID))
                return Json(_horasTrabalhadasRepository.GetHorasByDateAndUser(Convert.ToDateTime(dia), Convert.ToInt32(usuarioID)));

            return Json(_horasTrabalhadasRepository.GetHorasByDate(Convert.ToDateTime(dia)));
        }

        // GET horas/5
        [HttpGet("{usuarioID}")]
        public JsonResult Get(int usuarioID)
        {
            return Json(_horasTrabalhadasRepository.GetHorasByUser(usuarioID));
        }


        //POST horas
        [HttpPost]
        public JsonResult Post([FromBody] HorasTrabalhadas value)
        {
            return Json(_horasTrabalhadasRepository.AddHoras(value));
        }
    }
}