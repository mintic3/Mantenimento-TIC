using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioCliente: IRepositorioCliente{

        private readonly ApplicationContext  _ApplicationContext;

        public RepositorioCliente(){}

        public RepositorioCliente(ApplicationContext _applicationContext) {
            _applicationContext = _applicationContext;
        }
        
        void RepositorioCliente.AddCliente(Cliente cliente) {
            var new_cliente = _applicationContext.Clientes.Add(Cliente);
            _applicationContext.SaveChanges();
            return new_cliente.Entity;
        }
        void IRepositorioCliente.DeleteCliente(int idCliente) {
            var clienteEncontrado = _applicationContext.Clientes.FirstOrDefault(p => p.Id == idCliente);

            if (clienteEncontrado == null)
                return;

            _applicationContext.RemoveCliente(clienteEncontrada);
            _applicationContext.SaveChanges();
        }

        IEnumerable<Cliente> IRepositorioCliente.GetAllPersona(){
            return _applicationContext.Clientes;
        }

        void IRepositorioCliente.GetCliente(int idCliente){
            var clienteEncontrado = applicationContext.personas.FirstOrDefault(p => p.Id == IdPersona);
            if (clienteEncontrado != null){
                clienteEncontrado.telefono = cliente.telefono;
                clienteEncontrado.ciudad = cliente.ciudad;
                clienteEncontrado.direccion = cliente.direccion;
                clienteEncontrado.correo = cliente.correo;
                clienteEncontrado.login = cliente.login;
                clienteEncontrado.persona = cliente.persona;
            }
            _applicationContext.SaveChanges();
            return clienteEncontrado;
        }

        void IRepositorioCliente.UpdateCliente(Cliente cliente) {
            var personaEncontrado = _applicationContext.personas.FirstOrDefault(p => p.Id == idCliente);
            if (clienteEncontrado != null){
                clienteEncontrado.telefono = cliente.telefono;
                clienteEncontrado.ciudad = cliente.ciudad;
                clienteEncontrado.direccion = cliente.direccion;
                clienteEncontrado.correo = cliente.correo;
                clienteEncontrado.login = cliente.login;
                clienteEncontrado.persona = cliente.persona;
            }
            _applicationContext.SaveChanges();
            return clienteEncontrado;
        }
    }
}
