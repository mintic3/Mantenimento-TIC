using System.Linq;
using System.Collections.Generic;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersona: IRepositorioPersona {

        private readonly ApplicationContext  context;

        public RepositorioPersona(){}

        public RepositorioPersona(ApplicationContext _applicationContext) {
            context = _applicationContext;
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersona(){
            return context.Persona;
        }
        
        Persona IRepositorioPersona.AddPersona(Persona persona) {
            var newPersona = context.Persona.Add(persona);
            context.SaveChanges();
            return persona;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona) {
            Persona personaEncontrada = context.Persona.FirstOrDefault(p => p.id == persona.id);
            if (personaEncontrada != null) {
                personaEncontrada.nombres = persona.nombres;
                personaEncontrada.apellidos = persona.apellidos;
                personaEncontrada.fecha_nacimiento = persona.fecha_nacimiento;
                personaEncontrada.identificacion = persona.identificacion;
                personaEncontrada.tipo_id = persona.tipo_id;
                personaEncontrada.genero = persona.genero;
                personaEncontrada.fecha_registro = persona.fecha_registro;
            }
            context.SaveChanges();
            return personaEncontrada;
        }
        void IRepositorioPersona.DeletePersona(int idPersona) {
            var personaEncontrada = context.Persona.FirstOrDefault(p => p.id == idPersona);

            if (personaEncontrada == null)
                return;

            context.Remove(personaEncontrada);
            context.SaveChanges();
        }

        Persona IRepositorioPersona.GetPersona(int idPersona){
            var personaEncontrada = context.Persona.FirstOrDefault(p => p.id == idPersona);
            return personaEncontrada;
        }
    }
}
