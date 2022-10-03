using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{   
    public partial class CargaVuelo : Form
    {
        Vuelo vueloAux;
        public CargaVuelo()
        {
            InitializeComponent();
            Cbo_DestintosListado();
            string[] items = Aerolinea.RetornarMatriculasFlotaAvionesEnArrayDeString();
            cbo_aviones.Items.AddRange(items);
        }

        public Vuelo VueloAux { get { return vueloAux; } }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cbo_DestintosListado()
        {
            if (chk_internacional.Checked is true)
            {
                cbo_destinos.Items.Clear();
                string[] destinos = new string[] { "Recife", "Roma", "Acapulco", "Miami" };
                cbo_destinos.Items.AddRange(destinos);
            }
            else
            {
                cbo_destinos.Items.Clear();
                string[] destinos = new string[] { "Santa Rosa", "Bariloche", "Corrientes", "Córdoba",
                    "Jujuy","Mendoza","Neuquén", "Posadas", "Iguazú", "Salta", "Santiago del Estero",
                    "Trelew","Tucumán","Puerto Madryn","Ushuaia" };
                cbo_destinos.Items.AddRange(destinos);
            }
        }

        private void chk_internacional_CheckedChanged(object sender, EventArgs e)
        {
            cbo_destinos.Text = "";
            Cbo_DestintosListado();
        }

        private void btn_cargarVelo_Click(object sender, EventArgs e)
        {
            if(txt_idVuelo.Text != "" && cbo_aviones.Text != "" && cbo_destinos.Text != "")
            {
                vueloAux = new Vuelo(txt_idVuelo.Text, cbo_destinos.Text, int.Parse(cbo_aviones.Text), mca_fecha.SelectionStart);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos primero");
            }
        }
    }
}
