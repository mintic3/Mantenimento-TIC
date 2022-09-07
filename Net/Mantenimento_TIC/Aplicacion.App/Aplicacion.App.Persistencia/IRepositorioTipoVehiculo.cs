using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioTipoVehiculo {
        IEnumerable <TipoVehiculo> GetAllTipoVehiculo();
        TipoVehiculo AddTipoVehiculo(TipoVehiculo TipoVehiculo);
        TipoVehiculo UpdatePersona(TipoVehiculo TipoVehiculo);
        void DeleteTipoVehiculo (int idTipoVehiculo);
        TipoVehiculo GetTipoVehiculo(int idTipoVehiculo);
    }
}