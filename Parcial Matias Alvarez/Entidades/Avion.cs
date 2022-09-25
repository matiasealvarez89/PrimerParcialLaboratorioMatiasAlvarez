using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        int id;
        int cantidadAsientos;
        int cantidadAsientosPremium;
        float capacidadEquipaje;
        bool wifi;
        bool comida;

        public Avion()
        {

        }
        
        public Avion(int id, int cantidadAsientos, float capacidadEquipaje,bool wifi, bool comida)
        {
            this.id = id;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadAsientosPremium = CalcularAsientosPremium(cantidadAsientos);
            this.capacidadEquipaje = capacidadEquipaje;
            this.wifi = wifi;
            this.comida = comida;
        }

        static int CalcularAsientosPremium(int cantidadAsientos)
        {
            return (int)(cantidadAsientos * 0.2);
        }

        public int Id { get { return id; } }

        public int CantidadAsientos { get { return cantidadAsientos; } }

        public int CantidadAsientosPremium { get { return cantidadAsientosPremium;  } }

        public float CapacidadEquipaje { get { return capacidadEquipaje; } }

        public bool Wifi { get { return wifi; } } 

        public bool Comida { get { return comida; } }  

    }
}
