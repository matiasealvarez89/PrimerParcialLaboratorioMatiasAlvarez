namespace Entidades
{

    static public class Aerolinea
    {
        static List<Usuario> listadoEmpleados;
        static List<Persona> listadoPersonas;

        static Aerolinea()
        {
            listadoEmpleados = new List<Usuario>();
            listadoPersonas = new List<Persona>();

            CargarEmpleados();
            CargarPersonas();
        }

        private static void CargarEmpleados()
        {
            listadoEmpleados.Add(new Usuario("matias", "123"));
            listadoEmpleados.Add(new Usuario("jorge", "pep32"));
            listadoEmpleados.Add(new Usuario("lucas", "5746"));
            listadoEmpleados.Add(new Usuario("clara", "4532"));
        }

        private static void CargarPersonas()
        {
            listadoPersonas.Add(new Persona("Camila", "Perez", 2345123, new DateTime(2000, 11, 4)));
            listadoPersonas.Add(new Persona("Daiana", "Ledros", 40234321, new DateTime(2005, 9, 17)));
            listadoPersonas.Add(new Persona("Marcos", "Rojo", 30234657, new DateTime(1989, 6, 12)));
            listadoPersonas.Add(new Persona("Florencia", "Juarez", 34864557, new DateTime(1990, 8, 25)));
            listadoPersonas.Add(new Persona("Ariel", "Hefre", 32104665, new DateTime(1996, 3, 23)));

        }

        public static Usuario ValidarUsuario(string nombre, string pass)
        {

            if(nombre != null && pass != null)
            {
                foreach (Usuario item in listadoEmpleados)
                {
                    if (nombre == item.user && pass == item.clave)
                    {
                        return item;
                    }
                }
            }                     
            return null;
        }

        public static Persona EncontrarPersona(int dni)
        {            
            foreach (Persona item in listadoPersonas)
            {
                if(dni == item.Dni)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<Persona> ListadoPersonas()
        {
            return listadoPersonas;
        }
        
        public static int AgregarPersona(Persona persona)
        {
            if (persona != null)
            {
                listadoPersonas.Add((Persona)persona);
                return 0;
            }
            return -1;
        }

    }
}