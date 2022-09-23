using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    
    public class Usuario
    {
        public string user;
        public string clave;

        public Usuario(string user, string clave)
        {
            this.user = user;
            this.clave = clave;
        }        

    }
}
