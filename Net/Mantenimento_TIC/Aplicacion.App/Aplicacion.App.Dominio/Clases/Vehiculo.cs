using System;
namespace Aplicacion.App.Dominio
{
    public class Vehiculo{
     public int Id {get;set;}
     public string Fabricante {get;set;}
     public string TipoCombustible {get;set;}
     public string Modelo {get;set;}
     public int Cilindraje {get;set;}
     public int Kilometraje {get;set;}
     public string TipoMotor {get;set;}
     public bool Polarizados {get;set;}
     public Historial Historial {get;set;}
     public Tecnico Tecnico {get;set;}
  }

}