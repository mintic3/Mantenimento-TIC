using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioTecnico {
        IEnumerable <Tecnico> GetAllTecnico();
        Tecnico AddTecnico(Tecnico Tecnico);
        Tecnico UpdateTecnico(Tecnico Tecnico);
        void DeleteTecnico (int idTecnico);
        Tecnico GetTecnico(int idTecnico);
    }
}