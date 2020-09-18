using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class LoginModel : PageModel
    {
        [Required(ErrorMessage = "O login deve ser inserido.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "A senha deve ser inserida.")]
        public string Senha { get; set; }

        public void OnGet()
        {

        }
    }
}