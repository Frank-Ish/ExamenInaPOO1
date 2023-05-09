using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BColor : IBAutomovil<tbColor>
    {
        DColor _data = new DColor();

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
            return _data.obtenerTodos();
        }
    }
}
