using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    
    public enum DestinosNacional
    {
        Santa_Rosa,
        Bariloche,
        Corrientes,
        Córdoba,
        Jujuy,
        Mendoza,
        Neuquén,
        Posadas,
        Iguazú,
        Salta,
        Santiago_del_Estero,
        Trelew,
        Tucumán,
        Puerto_Madryn,
        Ushuaia
    }
    public enum DestinosInternacional
    {
        Recife,
        Roma,
        Acapulco,
        Miami
    }    
    
    public class Vuelo
    {
        string id;
        string destino;
        int idAvion;
        static List<int> idPasajeros = new List<int> ();        
        string internacional;
        DateTime salida;
        DateTime llegada;
        float recaudacion;
        int cantidadPasajeros;
        float duracionVuelo;
        string? asientosDisponibles;
        string? asientosDisponiblesPremium;

        public Vuelo(string id, string destino, int idAvion, DateTime salida)
        {
            this.id = id;
            this.destino = destino;
            this.idAvion = idAvion;
            this.salida = salida;
            this.internacional = EsInternacional(destino);
            CalcularHorarioLlegada();
            this.duracionVuelo = CalcularDuracionVuelo();                       
            ActualizarVuelo();             
        }

        public string Id
        {
            get { return id; }
        }

        public string Destino { get { return destino; } }

        public string Internacional
        {
            get { return internacional; }
        }

        private int IdAvion
        {
            get { return idAvion; }
        }

        public DateTime Salida { get { return salida; } }

        public DateTime Llegada { get { return llegada; } }

        public float Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }

        public int CantidadPasajeros
        {
            get { return cantidadPasajeros; }
            set { this.cantidadPasajeros = value; }
        }

        public float DuracionVuelo
        {
            get { return duracionVuelo; }
        }

        public string? AsientosDisponibles
        {
            get { return asientosDisponibles; }
            set { this.asientosDisponibles = value; }
        }

        public string? AsientosDisponiblesPremium
        {
            get { return asientosDisponiblesPremium; }
            set { this.asientosDisponiblesPremium = value; }
        }
        public void ActualizarVuelo()
        {
            idPasajeros = Aerolinea.RetornarListaIdPasajePorIdVuelo(Id);
            CantidadPasajeros = idPasajeros.Count;
            Recaudacion = CalcularRecaudacion();
            AsientosDisponibles = CalcularAsientosDisponibles();
            AsientosDisponiblesPremium = CalcularAsientosDisponiblesPremium();
        }     

        public float CalcularRecaudacion() 
        {
            float value = 0;
            List<Pasaje> aux = ListaPasajeVuelo();

            foreach (Pasaje item in aux)
            {
                value += item.Precio;
            }
            return value;
        }

        private List<Pasaje> ListaPasajeVuelo()
        {
            List<Pasaje> auxListaPasajes = new List<Pasaje>();
            if (idPasajeros.Count > 0)
            { 
                Pasaje? auxPasaje = null;

                foreach (int id in idPasajeros)
                {
                    auxPasaje = Aerolinea.RetornarPasajePorId(id);
                    if(auxPasaje != null)
                    {
                        auxListaPasajes.Add(auxPasaje);
                    }
                }                
            }
            return auxListaPasajes;
        }

        private void CalcularHorarioLlegada()
        {            
            Random rand = new Random();
            int horaDuacion;
            switch (Internacional)
            {
                case "No":
                    horaDuacion = rand.Next(2, 4);
                    this.llegada = this.salida.AddHours(horaDuacion);
                    break;
                case "Si":
                    horaDuacion = rand.Next(8, 12);
                    this.llegada = this.salida.AddHours(horaDuacion);
                    break;
            }            
        }

        public float CalcularDuracionVuelo()
        {
            TimeSpan aux;
            float duracion;

            aux =  llegada - salida;

            duracion = aux.Hours;

            return duracion;
        }
        
        private string EsInternacional(string destino)
        {
            string retorno = "No";            

            if (destino == "Recife" || destino == "Roma" || destino == "Acapulco" || destino == "Miami")
            {
                retorno = "Si";
            }
            return retorno;           
        }      

        private string CalcularAsientosDisponibles()
        {
            Avion? aux = Aerolinea.RetornarAvionPorId(IdAvion);
            int contadorAsientos = 0;
            List<Pasaje> listaPasajeros = ListaPasajeVuelo();
            string retorno;

            foreach (Pasaje pasaje in listaPasajeros)
            {
                if(!pasaje.EsPremium)
                {
                    contadorAsientos++;
                }
            }

            
            retorno = contadorAsientos + "/" + aux.CantidadAsientos;
            return retorno; 
        }

        private string CalcularAsientosDisponiblesPremium()
        {
            Avion? aux = Aerolinea.RetornarAvionPorId(IdAvion);
            int contadorAsientos = 0;
            List<Pasaje> listaPasajeros = ListaPasajeVuelo();
            string retorno;

            foreach (Pasaje pasaje in listaPasajeros)
            {
                if (pasaje.EsPremium)
                {
                    contadorAsientos++;
                }
            }

            retorno = contadorAsientos + "/" + aux.CantidadAsientosPremium;
            return retorno;
        }

        public bool VerificarSiPasajeEstaEnElVuelo(int dni)
        {
            foreach(Pasaje item in Aerolinea.FiltrarListaPasajePorIdVuelo(Id))
            {
                if(item.Persona.Dni == dni)
                {
                    return true;
                }
            }
            return false;    
            
        }

        public void AgregarIdPasajeroAVuelo(int id)
        {
            idPasajeros.Add(id);            
            ActualizarVuelo();
        }

        public void AgregarIdPasajeroAVueloCantidad(List<int> ids)
        {
            if (ids != null)
            {
                idPasajeros.AddRange(ids);
                ActualizarVuelo();
            }
            
        }

        public string ImprimirDniListaPasajeros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int dni in idPasajeros)
            {
                sb.AppendLine(dni.ToString());
            }
            return sb.ToString();
        }

        public bool EstaCompleto()
        {
            Avion avion = Aerolinea.RetornarAvionPorId(IdAvion);

            if(cantidadPasajeros < avion.CantidadAsientos)
            {
                return false;
            }            
            return true;
        }
    }
}
