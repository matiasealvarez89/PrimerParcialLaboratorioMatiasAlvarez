using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    
    public class Usuario : Persona
    {
        string user;
        string clave;
        bool esAdmin;


        public Usuario(string user, string clave)
        {
            this.user = user;
            this.clave = clave;
        }

        public Usuario(string user, string clave, string nombre, string apellido, int dni, DateTime fechaNacimiento):base(nombre,apellido,dni,fechaNacimiento)
        {
            this.user = user;
            this.clave = clave;
        }

        public Usuario(string user, string clave, bool esAdmin):this(user,clave)
        {
            this.esAdmin = esAdmin;
        }

        public string User { get { return this.user; } }

        public string Clave { get { return this.clave; } }

        public bool EsAdmin { get { return this.esAdmin; } }

    }
}
