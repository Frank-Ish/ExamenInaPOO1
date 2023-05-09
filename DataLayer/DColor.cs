using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DColor : IDAutomovil<tbColor>
    {
        public bool eliminar(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public tbColor guardar(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public tbColor obtenerPorID(tbColor entity)
        {
            throw new NotImplementedException();
        }

        public List<tbColor> obtenerTodos()
        {
            using (var context = new dbExamen1POOEntities())
            {
                // Obtener todas las entidades de la base de datos
                var data = context.tbColor.ToList();

                // Devolver los datos
                return data;
            }
        }
    }
}
