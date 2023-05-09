using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BMarca : IBAutomovil<tbMarca>
    {
        DMarca _data = new DMarca();
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
            return _data.obtenerTodos();
        }
    }
}
