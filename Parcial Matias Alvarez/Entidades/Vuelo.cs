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
        Avion avion = new Avion();
        List<int> idPasajeros = new List<int> ();
        bool comida;
        bool wifi;
        bool internacional;
        DateTime salida;
        DateTime llegada;
        int cantidadAsientos;
        int cantidadAsientosPremium;        
        float capacidadEquipaje;


        public bool Internacional
        {
            get { return internacional; }
        }

        public string Id
        {
            get { return id; }
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
            if(this.salida != null)
            {
                Random rand = new Random();
                float horaDuacion;
                switch (Internacional)
                {
                    case false:
                        horaDuacion = rand.Next(2, 4);
                        this.llegada = this.salida.AddHours(horaDuacion);
                        break;
                    case true:
                        horaDuacion = rand.Next(8, 12);
                        this.llegada = this.salida.AddHours(horaDuacion);
                        break;
                }
            }
        }

        public float DuracionVuelo()
        {
            TimeSpan aux;
            float duracion;

            aux = llegada - salida;

            duracion = aux.Hours;

            return duracion;
        }
        
        
        
        
        
    }
}
