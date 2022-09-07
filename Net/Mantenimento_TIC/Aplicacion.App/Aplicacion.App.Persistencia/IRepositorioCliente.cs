using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class IRepositorioCliente {
        IEnumerable <Cliente> GetAllCliente();
        Cliente AddCliente (Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente (int idCliente);
        Cliente GetCliente(int idCliente);
    }
}