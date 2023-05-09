using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class BTipoVehiculo : IBAutomovil<tbTipoVehiculo>
    {
        DTipoVehiculo _data = new DTipoVehiculo();
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
            return _data.obtenerTodos();
        }
    }
}
