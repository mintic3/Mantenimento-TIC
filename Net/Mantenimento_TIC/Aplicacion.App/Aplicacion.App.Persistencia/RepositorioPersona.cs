using System;
using System.Collections.Generic;
//using System.Ling;
//using system.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersona: IRepositorioPersona {

        private readonly ApplicationContext  _applicationContext;

        public Repositorio(){}

        public Repositorio(ApplicationContext _applicationContext) {
            _applicationContext = _applicationContext;
        }
        
        void IRepositorioPersona.AddPersona(Persona persona) {
            var new_persona = _applicationContext.personas.Add(persona);
            _applicationContext.SaveChanges();
            return new_persona.Entity;
        }
        void IRepositorioPersona.DeletePersona(int idPersona) {
            var personaEncontrada = _applicationContext.personas.FirstOrDefault(p => p.Id == idPersona);

            if (personaEncontrada == null)
                return;

            _applicationContext.RemovePersona(personaEncontrada);
            _applicationContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAll(){
            return _applicationContext.personas;
        }

        void IRepositorioPersona.GetPersona(int idPersona){
            var personaEncontrada = applicationContext.personas.FirstOrDefault(p => p.Id == IdPersona);
            if (personaEncontrada != null){
                personaEncontrada.Nombres = persona.Nombres;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Fecha_nacimiento = persona.Fecha_nacimiento;
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Tipo_id = persona.Tipo_id;
            }
            _applicationContext.SaveChanges();
            return personaEncontrada;
        }

        void IRepositorioPersona.UpdatePersona(Persona persona) {
            var personaEncontrada = _applicationContext.personas.FirstOrDefault(p => p.Id == IdPersona);
            if (personaEncontrada != null) {
                personaEncontrada.Nombres = persona.Nombres;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Fecha_nacimiento = persona.Fecha_nacimiento;
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Tipo_id = persona.Tipo_id;
                personaEncontrada.Genero = persona.Genero;
                personaEncontrada.Fecha_registro = persona.Fecha_registro;
            }
            _applicationContext.SaveChanges();
            return personaEncontrada;
        }
    }
}
