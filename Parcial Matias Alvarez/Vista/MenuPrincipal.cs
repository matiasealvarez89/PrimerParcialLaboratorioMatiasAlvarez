using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;        
        List<Persona> listaPersonas = Aerolinea.ListadoPersonas();
        List<Pasaje> listaPasajes = Aerolinea.ListadoPasajes();

        public MenuPrincipal(Usuario aux)
        {
            InitializeComponent();

            usuario = aux;
            lbl_nombreUsuario.Text = "Usuario: " + usuario.user;

            ActualizarListaPersonas();
        }

        private void ActualizarListaPersonas()
        {
            dgv_listadoPersonas.DataSource = null;
            dgv_listadoPersonas.DataSource = listaPasajes;

        }
        public void CargarPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        private void btn_cargarPersona_Click(object sender, EventArgs e)
        {
            Persona personaAcargar;
            CargaPersona cargaPersona = new CargaPersona();

            if (DialogResult.OK == cargaPersona.ShowDialog())
            {
                personaAcargar = cargaPersona.ObtenerPersona;

                CargarPersona(personaAcargar);
                ActualizarListaPersonas();

                MessageBox.Show($"nombre {personaAcargar.Nombre}");
            }            
        }
    }
}
