using DataLayer;
using Entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BAutomovil : IBAutomovil<tbAutomovil>
    {
        DAutomivil _data = new DAutomivil();

        public BAutomovil()
        {
        }

        public BAutomovil(DAutomivil data)
        {
            _data = data;
        }

        public bool eliminar(tbAutomovil entity)
        {
            throw new NotImplementedException();
        }

        public tbAutomovil guardar(tbAutomovil entity)
        {
            return _data.guardar(entity);
        }

        public bool modificar(tbAutomovil entity)
        {
            throw new NotImplementedException();
        }

        public tbAutomovil obtenerPorID(tbAutomovil entity)
        {
            throw new NotImplementedException();
        }

        public List<tbAutomovil> obtenerTodos()
        {
            return _data.obtenerTodos();
        }
    }
}
