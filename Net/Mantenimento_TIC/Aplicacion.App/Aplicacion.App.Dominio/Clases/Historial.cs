using System;
namespace Aplicacion.App.Dominio
{
    public class Historial{
        public int Id {get;set;}
        public string ClienteId {get;set;}
        public string RevisionId {get;set;}
        public string DetalleRevision {get;set;}
        public int Cantidad {get;set;}
        public int MatriculaId {get;set;}
        public string TotalServicio {get;set;}

        void Listar(){
            //Programacion
        }

  }

}