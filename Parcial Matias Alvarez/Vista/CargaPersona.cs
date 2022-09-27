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
    public partial class CargaPersona : Form
    {
       
        Persona persona;
        
        public  CargaPersona()
        {  
            InitializeComponent();            
        }       

        public void btn_accept_Click(object sender, EventArgs e)
        {
            if(txt_nombre.Text != "" && txt_apellido.Text != "" && txt_dni.Text != "" && dtp_fechaNacimiento.Value.Date < DateTime.Now)
            {
                if (!MenuPrincipal.ExistePersona(int.Parse(txt_dni.Text)))
                {
                    Persona nuevaPersona = new Persona(txt_nombre.Text, txt_apellido.Text, int.Parse(txt_dni.Text), (dtp_fechaNacimiento.Value.Date));
                    persona = nuevaPersona;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ya existe una persona cargada con ese DNI");
                }
            }
            else
            {
                MessageBox.Show("Revise los datos ingresados");                
            }                         
        }

        public Persona ObtenerPersona
        {
            get { return persona; }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
