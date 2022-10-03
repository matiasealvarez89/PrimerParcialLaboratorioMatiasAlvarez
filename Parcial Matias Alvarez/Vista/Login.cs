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
using Vista;

namespace Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario? aux = Aerolinea.ValidarUsuario(txt_usuario.Text, txt_pass.Text);

            if(aux != null)
            {
                this.Hide();

                MenuPrincipal menuPrincipal = new MenuPrincipal(aux);

                menuPrincipal.Show();                  
            }
            else
            {
                lbl_error.Visible = true;
            }
        }

        private void btn_autoLogueo_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "pepe98";
            txt_pass.Text = "1234";
            btn_ingresar.PerformClick();
        }
    }
}
