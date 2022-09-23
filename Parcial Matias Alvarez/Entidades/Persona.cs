using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        string nombre;
        string apellido;
        int dni;
        DateTime fechaNacimiento;
        int edad;

        public Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            edad = CalcularEdad(fechaNacimiento);            
        }   
        
        public Persona()
        {
            nombre = "";
            apellido = "";
            dni = 0;
            fechaNacimiento = new DateTime(1900, 1, 1);

        }

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            
            DateTime fechaActual = DateTime.Today;

           
            if (fechaNacimiento > fechaActual)
            {                
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;
                
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public int Edad
        {
            get { return edad; }
        }

    }
}
