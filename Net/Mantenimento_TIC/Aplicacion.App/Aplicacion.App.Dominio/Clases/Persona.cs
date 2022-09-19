using System;
namespace Aplicacion.App.Dominio
{
    public class Persona {
        public int id {get;set;}
        public string tipo_id {get;set;}
        public int tipoIdentificacion{get;set;}
        public int identificacion{get;set;}
        public string nombres {get;set;}
        public string correo {get;set;}
        public string apellidos {get;set;}
        public int celular {get;set;}
        public DateTime fecha_nacimiento {get;set;}
        public string genero {get;set;}
        public DateTime fecha_registro {get;set;}

        void edad() {
            //programacion
        }
    }

}