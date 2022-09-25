using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Pasaje
    {
        int id;
        Persona persona;
        string idVuelo;
        float precio;
        bool esPremium;
        int cantidadEquipaje;
        float pesoEquipaje;
        static int ultimoId = 5000;



        public Pasaje(int dni, string idVuelo,int cantidadEquipaje, float pesoEquiepaje, bool esPremium)
        {
            this.idVuelo = idVuelo;
            this.cantidadEquipaje = cantidadEquipaje;
            this.pesoEquipaje = pesoEquiepaje;
            this.esPremium = esPremium;
            CargarPersona(dni);
            CalcularPrecio();
            CargarId();
        }        
        
        private void CargarPersona(int dni)
        {
           if(dni != 0)
            {                
                foreach (Persona item in Aerolinea.ListadoPersonas())
                {
                    if(item.Dni == dni)
                    {
                        persona = item;
                        break;
                    }
                }
            }             
        }

        //public void CargarVuelo(string idVuelo)
        //{
        //    if (idVuelo != null)
        //    {
        //        foreach (Vuelo item in Aerolinea.ListadoVuelos())
        //        {
        //            if (item.Id == idVuelo)
        //            {
        //                vuelo = item;
        //                break;
        //            }
        //        }
        //    }
        //}

        public bool EsPremium
        {
            get { return esPremium; }
        }

        public float Precio
        {
            get { return precio; }
        }

        public int Id
        {
            get { return id; }
        }

        public int CantidadEquipaje
        {
            get { return cantidadEquipaje; }
        }
        public float PesoEquipaje
        {
            get { return pesoEquipaje; }
        }

        private void CalcularPrecio()
        {
            Vuelo auxVuelo = Aerolinea.RetornarVueloPorId(this.idVuelo);
            
            if(auxVuelo != null)
            {
                float duracion = auxVuelo.DuracionVuelo();
                float precio;

                switch (auxVuelo.Internacional)
                {
                    case false:
                        precio = duracion * 50;
                        break;
                    case true:
                        precio = duracion * 100;
                        break;
                }
                if (EsPremium)
                {
                    precio += precio * 15 / 100;
                }

                this.precio = precio;
            }
            
        }

        private void CargarId()
        {
            id = ultimoId;
            ultimoId++;
        }

    }
}
