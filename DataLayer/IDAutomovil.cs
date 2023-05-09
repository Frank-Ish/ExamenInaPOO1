using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDAutomovil <entidad>
    {
        entidad guardar(entidad entity);
        bool modificar(entidad entity);
        bool eliminar(entidad entity);
        entidad obtenerPorID(entidad entity);
        List<entidad> obtenerTodos();
    }
}
