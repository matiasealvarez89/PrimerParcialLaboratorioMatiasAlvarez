using Entidades;

namespace Formularios
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;
        static List<Persona> listaPersonas = Aerolinea.ListadoPersonas();
        List<Pasaje> listaPasajes = Aerolinea.ListadoPasajes();
        static List<Vuelo> listadoVuelos = Aerolinea.ListadoVuelos();
        List<Avion> flotaAviones = Aerolinea.FlotaAviones();


        public MenuPrincipal(Usuario aux)
        {
            InitializeComponent();

            usuario = aux;
            if(usuario.EsAdmin)
            {
                btn_cargarNuevoVuelo.Visible = true;
            }

            lbl_nombreUsuario.Text = "Usuario: " + usuario.User + " " + DateTime.Now.Date.ToString("dd-MM-yyyy");

            ActualizarListaVuelos();
        }

        public void ActualizarListaVuelos()
        {
            dgv_listadoVuelos.DataSource = null;
            dgv_listadoVuelos.DataSource = listadoVuelos;
        }



        public static void CargarPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public static Persona RetornarPersonaPorDNI(int dni)
        {
            if (dni != 0)
            {
                foreach (Persona persona in listaPersonas)
                {
                    if (dni == persona.Dni)
                    {
                        return persona;
                    }
                }
            }
            return null;
        }

        private void btn_cargarPersona_Click(object sender, EventArgs e)
        {
            Persona personaAcargar;
            CargaPersona cargaPersona = new CargaPersona();

            if (DialogResult.OK == cargaPersona.ShowDialog())
            {
                personaAcargar = cargaPersona.ObtenerPersona;

                CargarPersona(personaAcargar);
                ActualizarListaVuelos();

                MessageBox.Show($"Se cargo Correctamente a {personaAcargar.Nombre}");
            }
        }

        public static bool ExistePersona(int dni)
        {
            foreach (Persona persona in listaPersonas)
            {
                if (dni == persona.Dni)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgv_listadoVuelos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //this.dgv_listadoVuelos.Columns["Recaudacion"].DefaultCellStyle.Format = "c";
        }

        public static List<Vuelo> ListadoVueloMenu()
        {
            return listadoVuelos;
        }

        public static Vuelo RetornarVueloPorId(string idVuelo)
        {
            foreach (Vuelo vuelo in listadoVuelos)
            {
                if (vuelo.Id == idVuelo)
                {
                    return vuelo;
                }
            }
            return null;
        }

        public List<Pasaje> RetornarListaPasajes()
        {
            return listaPasajes;
        }

        private void btn_venderPasajes_Click(object sender, EventArgs e)
        {
            VentaPasajes ventaPasajes = new VentaPasajes();

            if(DialogResult.OK == ventaPasajes.ShowDialog())
            {
                if (ventaPasajes.ComprarMasPasajes == false)
                {
                    listaPasajes.Add(ventaPasajes.Pasaje);
                    ActualizarListaVuelos();
                    RetornarVueloPorId(ventaPasajes.IdVuelo).AgregarIdPasajeroAVuelo(ventaPasajes.Pasaje.Id);

                    ActualizarListaVuelos();
                }
                else
                {
                    listaPasajes.AddRange(ventaPasajes.PasajesVariosACargar);
                    ActualizarListaVuelos();
                    RetornarVueloPorId(ventaPasajes.IdVuelo).AgregarIdPasajeroAVueloCantidad(ventaPasajes.IdsAAgregarAVuelo);

                    ActualizarListaVuelos();
                }
            }
            
        }

        private void chk_listaPasajes_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_listaPasajes.Checked)
            {
                chk_listaPasajes.Checked = true;
                chk_listaPersonas.Checked = false;
                chk_listaVuelos.Checked = false;


                dgv_listadoVuelos.DataSource = null;
                dgv_listadoVuelos.DataSource = listaPasajes;
            }
            

        }

        private void chk_listaPersonas_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_listaPersonas.Checked)
            {
                chk_listaPersonas.Checked = true;
                chk_listaVuelos.Checked = false;
                chk_listaPasajes.Checked = false;


                dgv_listadoVuelos.DataSource = null;
                dgv_listadoVuelos.DataSource = listaPersonas;
            }
            
        }

        private void chk_listaVuelos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_listaVuelos.Checked)
            {
                chk_listaVuelos.Checked = true;
                chk_listaPersonas.Checked = false;
                chk_listaPasajes.Checked = false;


                dgv_listadoVuelos.DataSource = null;
                dgv_listadoVuelos.DataSource = listadoVuelos;
            }
            
        }
    }
}
