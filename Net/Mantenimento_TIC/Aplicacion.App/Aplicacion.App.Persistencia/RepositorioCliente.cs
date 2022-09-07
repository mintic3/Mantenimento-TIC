using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioCliente: IRepositorioCliente {

        private readonly ApplicationContext  _ApplicationContext;

        public RepositorioCliente(){}

        public RepositorioCliente(ApplicationContext _applicationContext) {
            _ApplicationContext = _applicationContext;
        }
        
        Cliente IRepositorioCliente.AddCliente(Cliente cliente) {
            var new_cliente = _ApplicationContext.Cliente.Add(cliente);
            _ApplicationContext.SaveChanges();
            return new_cliente.Entity;
        }
        void IRepositorioCliente.DeleteCliente(int idCliente) {
            var clienteEncontrado = _ApplicationContext.Cliente.FirstOrDefault(p => p.id == idCliente);

            if (clienteEncontrado == null)
                return;

            _ApplicationContext.Remove(clienteEncontrado);
            _ApplicationContext.SaveChanges();
        }

        IEnumerable<Cliente> IRepositorioCliente.GetAllCliente(){
            return _ApplicationContext.Cliente;
        }

        Cliente IRepositorioCliente.GetCliente(int idCliente){
            var clienteEncontrado = _ApplicationContext.Cliente.FirstOrDefault(p => p.id == idCliente);
            return clienteEncontrado;
        }

        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente) {
            var clientEncontrado = _ApplicationContext.Cliente.FirstOrDefault(p => p.id == cliente.id);
            if (clientEncontrado != null){
                //TODO agregar logica para actualizar datos en la BD
            }
            _ApplicationContext.SaveChanges();
            return clientEncontrado;
        }
    }
}
