using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class IRepositorioPersona {
        IEnumerable <Persona> GetAll();
        Persona Add(Persona persona);
        Persona Update(Persona persona);
        void Delete (int idPersona);
        Persona Get(int idPersona);
    }
}