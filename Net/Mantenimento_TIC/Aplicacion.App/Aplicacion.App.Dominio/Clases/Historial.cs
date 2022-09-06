using System;
namespace Aplicacion.App.Dominio
{
    public class Historial{
        public Historial(int id, string revision_id, int cantidad, string total_servicio) 
        {
            this.id = id;
    this.revision_id = revision_id;
    this.cantidad = cantidad;
    this.total_servicio = total_servicio
   
        }
                public int id {get;set;}
        public string cliente_id {get;set;}
        public string revision_id {get;set;}
        public string detalle_revision {get;set;}
        public int cantidad {get;set;}
        public int matricula_id {get;set;}
        public string total_servicio {get;set;}

        void Listar(){
            //Programacion
        }

  }

}