using System;
namespace Aplicacion.App.Dominio
{
    public class Tecnico:Persona{
        public int TiempoSolucion {get;set;}
        public string Especialidad {get;set;}
        public string CodigoEmpleado {get;set;}
        public string Estado {get;set;}
        public Historial Historial{get;set;}
        public LoginAcceso LoginAcceso {get;set;}
        public Revision Revision {get;set;}
        
        void Registrar (){
         //programacion
        }
        void Consultar (){
         //programacion
        }
        void login(){
         //programacion
        }
 }

}