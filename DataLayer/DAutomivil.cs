using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAutomivil : IDAutomovil<tbAutomovil>
    {
        
        public bool eliminar(tbAutomovil entity)
        {
            throw new NotImplementedException();
        }

        public tbAutomovil guardar(tbAutomovil entity)
        {
            try
            {
                using (var context = new dbExamen1POOEntities())
                {
                    context.tbAutomovil.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            using (var context = new dbExamen1POOEntities())
            {
                // Obtener todas las entidades de la base de datos
                var data = context.tbAutomovil.ToList();

                // Devolver los datos
                return data;
            }
        }
    }
}
