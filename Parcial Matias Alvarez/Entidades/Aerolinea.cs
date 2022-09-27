namespace Entidades
{

    static public class Aerolinea
    {
        static List<Usuario> listadoEmpleados;
        static List<Persona> listadoPersonas;
        static List<Avion> flotaAviones;
        static List<Vuelo> listadoVuelos;
        static List<Pasaje> listadoPasajes;

        static Aerolinea()
        {
            listadoEmpleados = new List<Usuario>();
            listadoPersonas = new List<Persona>();
            flotaAviones = new List<Avion>();
            listadoVuelos = new List<Vuelo>();
            listadoPasajes = new List<Pasaje>();

            CargarEmpleados();
            CargarPersonas();
            CargarFlotaAviones();
            CargarVuelos();
            CargarPasajes();            
            ActualizarListadoVuelos();
        }

        private static void CargarEmpleados()
        {
            listadoEmpleados.Add(new Usuario("matias", "123"));
            listadoEmpleados.Add(new Usuario("jorge", "pep32"));
            listadoEmpleados.Add(new Usuario("lucas", "5746"));
            listadoEmpleados.Add(new Usuario("clara", "4532"));
        }

        private static void CargarPasajes()
        {
            listadoPasajes.Add(new Pasaje(2345123, "HF-598", 1, 20, false));
            listadoPasajes.Add(new Pasaje(40234321, "HF-598", 2, 20, true));
            listadoPasajes.Add(new Pasaje(34864557, "HF-598", 2, 20, true));
            listadoPasajes.Add(new Pasaje(30234657, "HF-598", 2, 15, true));
            listadoPasajes.Add(new Pasaje(32104665, "HF-598", 1, 15, false));
        }

        private static void CargarVuelos()
        {
            listadoVuelos.Add(new Vuelo("HF-598", "Recife", 3245, new DateTime(2022, 11, 6, 9, 30, 0)));
        }

        private static void CargarPersonas()
        {
            listadoPersonas.Add(new Persona("Camila", "Perez", 2345123, new DateTime(2000, 11, 4)));
            listadoPersonas.Add(new Persona("Daiana", "Ledros", 40234321, new DateTime(2005, 9, 17)));
            listadoPersonas.Add(new Persona("Marcos", "Rojo", 30234657, new DateTime(1989, 6, 12)));
            listadoPersonas.Add(new Persona("Florencia", "Juarez", 34864557, new DateTime(1990, 8, 25)));
            listadoPersonas.Add(new Persona("Ariel", "Hefre", 32104665, new DateTime(1996, 3, 23)));

        }

        private static void CargarFlotaAviones()
        {
            flotaAviones.Add(new Avion(1623, 80, 300, true, true));
            flotaAviones.Add(new Avion(3245, 64, 200, true, false));
            flotaAviones.Add(new Avion(6329, 142, 500, true, true));
            flotaAviones.Add(new Avion(8923, 48, 150, false, false));
            flotaAviones.Add(new Avion(1007, 72, 210, false, true));
            flotaAviones.Add(new Avion(2939, 42, 208, false, false));
            flotaAviones.Add(new Avion(9929, 128, 450, true, true));
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

        public static List<Vuelo> ListadoVuelos()
        {
            return listadoVuelos;
        }

        public static List<Pasaje> ListadoPasajes()
        {
            return listadoPasajes;
        }

        public static List<Avion> FlotaAviones()
        {
            return flotaAviones;
        }

        public static Vuelo RetornarVueloPorId(string id)
        {
            foreach (Vuelo item in listadoVuelos)
            {
                if(id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Pasaje RetornarPasajePorId(int id)
        {
            foreach (Pasaje item in listadoPasajes)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Avion RetornarAvionPorId(int id)
        {
            foreach (Avion item in flotaAviones)
            {
                if(id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<int> RetornarListaIdPasajePorIdVuelo(string idVuelo)
        {
            List<int> listaIdPasajePorId = new List<int>();

            foreach (Pasaje item in listadoPasajes)
            {
                if(idVuelo == item.IdVuelo)
                {
                    listaIdPasajePorId.Add(item.Id);
                }
            }
            return listaIdPasajePorId;
        }

        private static void ActualizarListadoVuelos()
        {
            foreach (Vuelo item in listadoVuelos)
            {
                item.ActualizarVuelo();
            }
        }

    }
}