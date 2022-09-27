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


        public Pasaje(int dni, string idVuelo, bool esPremium)
        {
            this.idVuelo = idVuelo;
            this.esPremium = esPremium;
            CargarPersona(dni);
            CalcularPrecio();
            CargarId();
        }
        public Pasaje(int dni, string idVuelo,int cantidadEquipaje, float pesoEquiepaje, bool esPremium) : this (dni,idVuelo,esPremium)
        {            
            this.cantidadEquipaje = cantidadEquipaje;
            this.pesoEquipaje = pesoEquiepaje;           
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

        public string IdVuelo
        {
            get { return idVuelo; }
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
            Vuelo auxVuelo = Aerolinea.RetornarVueloPorId(IdVuelo);
            
            if(auxVuelo != null)
            {
                float duracion = auxVuelo.CalcularDuracionVuelo();
                float precio = 0;

                switch (auxVuelo.Internacional)
                {
                    case "No":
                        precio = duracion * 50;
                        break;
                    case "Si":
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
