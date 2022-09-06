using System;

namespace Aplicacion.App.Persistencia
{
    public class Repositorio
    {
        private readonly ApplicationContext _applicationContext;
        public Repositorio(ApplicationContext applicationContext){
            _applicationContext = _applicationContext;

        }
        public Repositorio(){}
        Persona IRepositorio.Add(Persona persona){
            var new_persona = applicationContext.personas.Add(persona);
            _applicationContext.saveChanges();
            return new_persona.Entity;
        }
        void IRepositorio.Delete(int IdPersona){
            var personaEncontrada = applicationContext.personas.FirstOrDefault(
                p = p.Id == IdPersona;
            );
            if (personaEncontrada == null)
            return;
            _applicationContext.Remove(personaEncontrada);
            _applicationContext.saveChanges();

        }
        IEnumerable<Persona> IRepositorio.GetAll(){
            return _applicationContext.personas;
        }
        Persona Get(int IdPersona){
            ar personaEncontrada = applicationContext.personas.FirstOrDefault(
                p = p.Id == IdPersona;
            );
            if (personaEncontrada !== null){
                personaEncontrada.Nombres = persona.Nombres;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Fecha_nacimiento = persona.Fecha_nacimiento;
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Tipo_id = persona.Tipo_id;
            }
            _applicationContext.saveChanges();
            return personaEncontrada;
            
        }
        Persona Update (Persona persona);

    }
}
