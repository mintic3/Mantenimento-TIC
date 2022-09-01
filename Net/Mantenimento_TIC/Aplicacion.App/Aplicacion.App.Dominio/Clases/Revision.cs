using System;
namespace Aplicacion.App.Dominio
{
    public class Revision{
        public int Id {get;set;}
        public int Codigo {get;set;}
        public int CodigoEmpleado {get;set;}
        public string NombreRevision {get;set;}
        public string TipoRevision {get;set;}
        public string FechaRevision {get;set;}
        public double Costo {get;set;}

        void Guardar (){
         //programacion
        }
        void Actualizar (){
         //programacion
        }
        void eliminar(){
         //programacion
        }
    }
 }