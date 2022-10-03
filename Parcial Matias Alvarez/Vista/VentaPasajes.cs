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
        private bool btn_consultarFueApretado = false;
        Pasaje pasajeAux = new Pasaje();
        bool flagCotizar = false;
        int dni;
        string idVuelo;
        bool comprarMasPasajes = false;
        List<Pasaje> pasajesVariosACargar = new List<Pasaje>();        
        List<int> idsAAgregarAVuelo = new List<int>();

        public VentaPasajes()
        {
            InitializeComponent();
            Cbo_DestintoListado();
            lbl_precio.Text = "Precio:\nSalida:\nLlegada:\nDuracion:";
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public bool ComprarMasPasajes
        {
            get { return comprarMasPasajes; }
            set { comprarMasPasajes = value; }
        }

        public string IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }

        public Pasaje Pasaje
        {
            get { return pasajeAux; }
        }

        public List<Pasaje> PasajesVariosACargar
        {
            get { return pasajesVariosACargar; }
        }

        public List<int> IdsAAgregarAVuelo
        {
            get { return idsAAgregarAVuelo; }
        }

        private string SacarIdVueloDeCbo(string texto)
        {
            string aux = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    aux += texto[i];
                }
                else
                {
                    break;
                }
            }
            return aux;
        }

        private void MostrarInfoPasajeEnLbl(Pasaje aux)
        {
            lbl_precio.Text = "Precio: U$S " + aux.Precio.ToString() +
                            $"\nSalida: {MenuPrincipal.RetornarVueloPorId(SacarIdVueloDeCbo(cbo_vuelo.Text)).Salida}\n" +
                            $"Llegada: {MenuPrincipal.RetornarVueloPorId(SacarIdVueloDeCbo(cbo_vuelo.Text)).Llegada}\n" +
                            $"Duracion: {MenuPrincipal.RetornarVueloPorId(SacarIdVueloDeCbo(cbo_vuelo.Text)).DuracionVuelo} Hs";
        }

        private void BloquearElementosDeConsulta()
        {
            txt_dni.ReadOnly = true;
            chk_internacional.Enabled = false;
            cbo_destino.Enabled = false;
            cbo_vuelo.Enabled = false;
            chk_esPremium.Enabled = false;
            cbo_cantidadValijas.Enabled = true;

            if (chk_esPremium.Checked)
            {
                string[] items = new string[] { "1", "2" };
                cbo_cantidadValijas.Items.AddRange(items);
            }
            else
            {
                cbo_cantidadValijas.Items.Add("1");
            }
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
                    btn_consultarFueApretado = true;
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
                        btn_consultarFueApretado = true;

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
            if (chk_internacional.Checked is true)
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
            cbo_destino.Text = "";
            Cbo_DestintoListado();
        }

        private void Cbo_VueloGeneraListado()
        {
            if (cbo_destino.Text != null)
            {

                List<string> auxVuelos = new List<string>();

                foreach (Vuelo vuelo in MenuPrincipal.ListadoVueloMenu())
                {
                    if (cbo_destino.Text == vuelo.Destino)
                        auxVuelos.Add($"{vuelo.Id} - {vuelo.Salida} - {vuelo.Llegada}");
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

        private void btn_cotizar_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text != "" && cbo_destino.Text != "" && cbo_vuelo.Text != "")
            {
                if (btn_consultarFueApretado)
                {
                    BloquearElementosDeConsulta();
                    Vuelo vueloAux = MenuPrincipal.RetornarVueloPorId(SacarIdVueloDeCbo(cbo_vuelo.Text));

                    if (!vueloAux.VerificarSiPasajeEstaEnElVuelo(int.Parse(txt_dni.Text)))
                    {
                        pasajeAux = new Pasaje(int.Parse(txt_dni.Text), SacarIdVueloDeCbo(cbo_vuelo.Text), chk_esPremium.Checked);
                        MostrarInfoPasajeEnLbl(pasajeAux);
                        flagCotizar = true;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe esta persona cargada en el vuelo");
                    }
                }
                else
                {
                    MessageBox.Show("Falta confirmar el dni");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los datos obligatorios");
            }
        }

       




        private void cbo_cantidadValijas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_cantidadValijas.Text == "2")
            {
                txt_peso2.Visible = true;
            }
            else if (cbo_cantidadValijas.Text == "1")
            {
                txt_peso2.Visible = false;
            }
        }

        private void chk_cargarValijasDespues_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_cargarValijasDespues.Checked)
            {
                cbo_cantidadValijas.Enabled=false;
                txt_peso1.ReadOnly = true;
                txt_peso2.ReadOnly = true;
            }
            else
            {
                cbo_cantidadValijas.Enabled = true;
                txt_peso1.ReadOnly = false;
                txt_peso2.ReadOnly = false;
            }
        }

        private void btn_comprarPasaje_Click(object sender, EventArgs e)
        {
            if(flagCotizar == true && pasajeAux != null)
            {
                if(!MenuPrincipal.RetornarVueloPorId(SacarIdVueloDeCbo(cbo_vuelo.Text)).EstaCompleto())
                {
                    this.Hide();
                    if (ComprarMasPasajes == false)
                    {
                        ImpresionPasaje impresionPasaje = new ImpresionPasaje(pasajeAux);
                        Dni = int.Parse(txt_dni.Text);
                        IdVuelo = pasajeAux.IdVuelo;
                        DialogResult = DialogResult.OK;
                        impresionPasaje.ShowDialog();
                    }
                    else
                    {
                        pasajesVariosACargar.Add(pasajeAux);
                        IdVuelo = pasajeAux.IdVuelo;
                        idsAAgregarAVuelo.Add(pasajeAux.GetHashCode());

                        foreach (Pasaje pasaje in pasajesVariosACargar)
                        {
                            ImpresionPasaje impresionPasaje = new ImpresionPasaje(pasajeAux);
                            impresionPasaje.ShowDialog();
                        }
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Vuelo completo");
                }
                
            }
            else
            {
                MessageBox.Show("Debe cotizar el vuelo primero");
            }      

        }

        private void LimpiarFormulario()
        {
            txt_dni.Text = "";
            txt_dni.ReadOnly = false;
            lbl_nombre.Text = "Nombre:";
            lbl_apellido.Text = "Apellido:";
            flagCotizar = false;            
            chk_esPremium.Enabled = true;
        }

        private void btn_comprarMasPasajes_Click(object sender, EventArgs e)
        {
            if (flagCotizar == true && pasajeAux != null)
            {
                pasajesVariosACargar.Add(pasajeAux);
                IdVuelo = pasajeAux.IdVuelo;
                idsAAgregarAVuelo.Add(pasajeAux.GetHashCode());                
                ComprarMasPasajes = true;
                LimpiarFormulario();                
            }
        }
    }
}
