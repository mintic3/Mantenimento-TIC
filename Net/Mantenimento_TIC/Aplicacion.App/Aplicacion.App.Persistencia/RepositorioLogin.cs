using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioLogin : IRepositorioLogin
    {
         private readonly ApplicationContext  _ApplicationContext;
         
        public RepositorioLogin(ApplicationContext _applicationContext) {
            _ApplicationContext = _applicationContext;
        }

        public Login actualizar(Login login)
        {
            var loginnEncontrado = _ApplicationContext.login.FirstOrDefault(p => p.id == login.id);
            if (loginnEncontrado != null){            
            }
            _ApplicationContext.SaveChanges();
            return loginnEncontrado;
        }

        public Login crearLogin(Login login)
        {
           var new_Login = _ApplicationContext.login.Add(login);
            _ApplicationContext.SaveChanges();
            return new_Login.Entity; 
        
        }

        public void DeleteLogin(int idLogin)
        {
            var loginEncontrado = _ApplicationContext.login.FirstOrDefault(p => p.id == idLogin);

            if (loginEncontrado == null)
               return;
            
            _ApplicationContext.Remove(loginEncontrado);
            _ApplicationContext.SaveChanges();

        }

        public IEnumerable<Login> hacerLogin()
        {
            return _ApplicationContext.login;
        }
    }
}