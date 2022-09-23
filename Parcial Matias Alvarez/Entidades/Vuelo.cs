using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    
    public class Vuelo
    {
        int id;
        string destino;
        Avion avion = new Avion();
        List<Pasajero> pasajeros = new List<Pasajero> ();
        bool comida;
        bool wifi;
        bool internacional;
        DateTime salida;
        DateTime llegada;
        int cantidadAsientos;
        int cantidadAsientosPremium;
        float recaudacion;
        int capacidadEquipaje;
    }
}
