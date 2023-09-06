using CapaData;
using CapaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UserLogic
    {
        //readonly restringe donde se puede modificar el context
        // para poder realizarlo en la misma linea o el constructor
        private readonly DassContext context;

        public UserLogic()
        {
            context = new DassContext();
        }

        public List<usuarios> GetAll()
        {
            //llama al metodo de extencion ToList que devuelve la lista de usuarios
            return context.usuarios.ToList();
        }
    }
}
