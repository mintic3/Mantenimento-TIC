using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.App.Persistencia
{
    public class IRepositorioTecnico{
        IEnumerable <Tecnico> GetAllTecnico();
        Tecnico AddTecnico(Tecnico Tecnico);
        Tecnico UpdateTecnico(Tecnico Tecnico);
        void DeleteTecnico (int idTecnico);
        Tecnico GetTecnico(int idTecnico);
    }
}