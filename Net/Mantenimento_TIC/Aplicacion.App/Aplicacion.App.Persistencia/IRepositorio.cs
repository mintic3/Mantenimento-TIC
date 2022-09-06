using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class IRepositorio
    {
        Persona Add(Persona persona);
        IEnumerable <Persona> GetAll();
        void Delete (int IdPersona);
        Persona Get(int IdPersona);
    }
}