using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace Vista
{
    public partial class Vista : Form
    {
        Usuario usuario;

        public Vista(Usuario aux)
        {                       
            InitializeComponent(); 
            usuario = aux;         
            
        }
    }
}