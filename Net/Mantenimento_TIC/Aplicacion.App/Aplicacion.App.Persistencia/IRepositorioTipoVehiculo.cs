using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class IRepositorioTipoVehiculo{
        IEnumerable <TipoVehiculo> GetAllTipoVehiculo();
        TipoVehiculo AddTipoVehiculo(TipoVehiculo TipoVehiculo);
        TipoVehiculo UpdatePersona(TipoVehiculo TipoVehiculo);
        void DeleteTipoVehiculo (int idTipoVehiculo);
        TipoVehiculo GetTipoVehiculo(int idTipoVehiculo);
    }
}