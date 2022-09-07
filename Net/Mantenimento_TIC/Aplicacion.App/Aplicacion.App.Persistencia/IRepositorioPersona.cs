using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class IRepositorioPersona {
        IEnumerable <Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona (int idPersona);
        Persona GetPersona(int idPersona);
    }
}