using System;
namespace Aplicacion.App.Dominio
{
    public class Cliente:Persona{
        public string Telefono {get;set;}
        public string Ciudad {get;set;}
        public string Direcion {get;set;}
        public string Correo {get;set;}
        public Historial Historial{get;set;}
        public LoginAcceso LoginAcceso{get;set;}
        public Vehiculo Vehiculo {get;set;}

        void Consultar (){
         //programacion
        }
        void Login (){
         //programacion
        }
        void ActualizarPerfil (){
         //programacion
        }

  }

}