using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioRevision : IRepositorioRevision
    {
        private readonly ApplicationContext  _ApplicationContext;
        public RepositorioRevision(ApplicationContext _applicationContext) {
            _ApplicationContext = _applicationContext;
        }

        public Revision actualizar(Revision revision)
        {
            var RevisionEncontrado = _ApplicationContext.Revision.FirstOrDefault(p => p.id == revision.id);
            if (RevisionEncontrado != null){            
            }
            _ApplicationContext.SaveChanges();
            return RevisionEncontrado;
        }

        public Revision AddRevision(Revision revision)
        {
            var new_Revision = _ApplicationContext.Revision.Add(revision);
            _ApplicationContext.SaveChanges();
            return new_Revision.Entity; 
        }

        public void eliminarRevision(int idRevision)
        {
            var RevisioEncontrado = _ApplicationContext.Revision.FirstOrDefault(p => p.id == idRevision);

            if (RevisioEncontrado == null)
               return;
            
            _ApplicationContext.Remove(RevisioEncontrado);
            _ApplicationContext.SaveChanges();
        }

        public IEnumerable<Revision> iniciarRevision()
        {
            throw new NotImplementedException();
        }
    }
}