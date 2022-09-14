using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace MyApp.Namespace
{
    public class usuarioRevisionModel : PageModel
    {
        private readonly IRepositorioLogin _repo;
        
        public Login Login {get;set;}

        public usuarioRevisionModel(IRepositorioLogin repositorio)
        {
            _repo = repositorio;
        }

        public void OnGet()
        {
        }
    }
}
