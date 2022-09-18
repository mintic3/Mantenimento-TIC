using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioRevision
    {
        IEnumerable <Revision>  iniciarRevision ();
        Revision AddRevision (Revision revision);
        Revision actualizar (Revision revision);
        void eliminarRevision (int idRevision);

    }
}