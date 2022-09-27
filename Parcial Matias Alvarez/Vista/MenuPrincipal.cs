using Entidades;

namespace Formularios
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;        
        List<Persona> listaPersonas = Aerolinea.ListadoPersonas();
        List<Pasaje> listaPasajes = Aerolinea.ListadoPasajes();
        List<Vuelo> listadoVuelos = Aerolinea.ListadoVuelos();
        List<Avion> flotaAviones = Aerolinea.FlotaAviones();


        public MenuPrincipal(Usuario aux)
        {
            InitializeComponent();

            usuario = aux;           
            lbl_nombreUsuario.Text = "Usuario: " + usuario.user + " " + DateTime.Now.Date.ToString("dd-MM-yyyy");

            ActualizarListaVuelos();            
        }

        private void ActualizarListaVuelos()
        {
            dgv_listadoVuelos.DataSource = null;
            dgv_listadoVuelos.DataSource = listadoVuelos;            
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
                ActualizarListaVuelos();

                MessageBox.Show($"Se cargo Correctamente a {personaAcargar.Nombre}");
            }            
        }

        private void dgv_listadoVuelos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.dgv_listadoVuelos.Columns["Recaudacion"].DefaultCellStyle.Format = "c";
            

            
        }
    }
}
