using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DTipoVehiculo : IDAutomovil<tbTipoVehiculo>
    {
        public bool eliminar(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoVehiculo guardar(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoVehiculo obtenerPorID(tbTipoVehiculo entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoVehiculo> obtenerTodos()
        {
            using (var context = new dbExamen1POOEntities())
            {
                // Obtener todas las entidades de la base de datos
                var data = context.tbTipoVehiculo.ToList();

                // Devolver los datos
                return data;
            }
        }
    }
}
