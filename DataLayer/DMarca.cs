using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DMarca : IDAutomovil<tbMarca>
    {
        public bool eliminar(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public tbMarca guardar(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public tbMarca obtenerPorID(tbMarca entity)
        {
            throw new NotImplementedException();
        }

        public List<tbMarca> obtenerTodos()
        {
            using (var context = new dbExamen1POOEntities())
            {
                // Obtener todas las entidades de la base de datos
                var data = context.tbMarca.ToList();

                // Devolver los datos
                return data;
            }
        }
    }
}
