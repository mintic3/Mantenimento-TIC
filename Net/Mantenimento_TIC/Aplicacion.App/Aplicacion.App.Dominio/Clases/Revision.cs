using System;
namespace Aplicacion.App.Dominio
{
    public class Revision {

        public int id {get;set;}
        public int codigo {get;set;}
        public int codigo_empleado {get;set;}
        public string nombre_revision {get;set;}
        public string tipo_revision {get;set;}
        public string fecha_revision {get;set;}
        public double costo {get;set;}
        public string detalle_revision {get;set;}
        public int vehiculo {get;set;}
        public int tecnico {get;set;}

        void guardar(){
         //programacion
        }
        void actualizar(){
         //programacion
        }
        void eliminar(){
         //programacion
        }
    }
 }