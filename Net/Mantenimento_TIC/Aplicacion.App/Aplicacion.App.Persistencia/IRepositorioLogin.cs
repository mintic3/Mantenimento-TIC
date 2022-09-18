using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioLogin{
        IEnumerable <Login> hacerLogin();
        Login crearLogin(Login login);
        Login actualizar(Login login);
        void DeleteLogin (int idLogin);

    }
}