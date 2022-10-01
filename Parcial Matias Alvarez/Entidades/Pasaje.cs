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


        public Pasaje()
        {

        }
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

        public Persona Persona
        {
            get { return persona; }
        }

        public void CalcularPrecio()
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

        public void CalcularPrecio(Vuelo auxVuelo)
        {           

            if (auxVuelo != null)
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

        public int RetornarDniPorId(int id)
        {
            if(id == Id)
            {
                return persona.Dni;
            }
            return 0;
        }

        public override string ToString()
        {
            Vuelo auxVuelo = Aerolinea.RetornarVueloPorId(this.IdVuelo);
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vuelo: {this.IdVuelo}");
            sb.AppendLine($"Precio: U$S {this.Precio}");
            sb.AppendLine($"Salida: {auxVuelo.Salida}");
            sb.AppendLine($"Llegada: {auxVuelo.Llegada}");
            sb.AppendLine($"Codigo de pasaje: {this.Id}");
            return sb.ToString();
        }

    }
}
