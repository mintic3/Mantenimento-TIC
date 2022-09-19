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
    public class registroNuevoModel : PageModel
    {
        private readonly IRepositorioPersona _repo;
        
        public Persona Persona {get;set;}
        public Login Login {get;set;}

        public registroNuevoModel(IRepositorioPersona repositorio)
        {
            _repo = repositorio;
        }

        public void OnGet()
        {
        }
    }
}