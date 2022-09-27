using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class VentaPasajes : Form
    {
        public VentaPasajes()
        {
            InitializeComponent();
            Cbo_DestintoListado();
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text != "" && int.TryParse(txt_dni.Text, out int dniIngresado))
            {
                Persona aux = MenuPrincipal.RetornarPersonaPorDNI(dniIngresado);

                if (aux != null)
                {
                    lbl_nombre.Text = $"Nombre: {aux.Nombre}";
                    lbl_apellido.Text = $"Apellido: {aux.Apellido}";
                }
                else
                {
                    CargaPersona cargaPersona = new CargaPersona();
                    cargaPersona.txt_dni.Text = dniIngresado.ToString();
                    cargaPersona.txt_dni.ReadOnly = true;

                    if (DialogResult.OK == cargaPersona.ShowDialog())
                    {
                        aux = cargaPersona.ObtenerPersona;

                        MenuPrincipal.CargarPersona(aux);

                        lbl_nombre.Text = $"Nombre: {aux.Nombre}";
                        lbl_apellido.Text = $"Apellido: {aux.Apellido}";

                        MessageBox.Show($"Se cargo Correctamente a {aux.Nombre}");
                    }                   
                }
            
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido");
            }
        }

        private void Cbo_DestintoListado()
        {
            if(chk_internacional.Checked is true)
            {    
                cbo_destino.Items.Clear();
                string[] destinos = new string[] { "Recife", "Roma", "Acapulco", "Miami" };
                cbo_destino.Items.AddRange(destinos);
            }
            else
            {
                cbo_destino.Items.Clear();
                string[] destinos = new string[] { "Santa Rosa", "Bariloche", "Corrientes", "Córdoba",
                    "Jujuy","Mendoza","Neuquén", "Posadas", "Iguazú", "Salta", "Santiago del Estero",
                    "Trelew","Tucumán","Puerto Madryn","Ushuaia" };
                cbo_destino.Items.AddRange(destinos);
            }
        }

        private void chk_internacional_CheckedChanged(object sender, EventArgs e)
        {
            Cbo_DestintoListado();
        }

        private void Cbo_VueloGeneraListado()
        {
            if(cbo_destino.Text != null)
            {
                
                List<string> auxVuelos = new List<string>();                

                foreach(Vuelo vuelo in MenuPrincipal.ListadoVueloMenu())
                {
                    if(cbo_destino.Text == vuelo.Destino)
                    auxVuelos.Add($"{vuelo.Id} / {vuelo.Salida} / {vuelo.Llegada}");
                }

                String[] auxPasajeString = auxVuelos.ToArray();

                cbo_vuelo.Items.AddRange(auxPasajeString);
            }
        }

        private void cbo_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_vuelo.Items.Clear();
            Cbo_VueloGeneraListado();
        }
    }
}
