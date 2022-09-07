using System.Collections.Generic;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioPersona {
        IEnumerable <Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona (int idPersona);
        Persona GetPersona(int idPersona);
    }
}