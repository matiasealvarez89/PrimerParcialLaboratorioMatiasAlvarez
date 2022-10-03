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
    public partial class Informes : Form
    {
        bool flagGenerar = false;

        public Informes()
        {
            InitializeComponent();
            Cbo_DestintosListado();
        }

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

        private void chk_internacional_CheckedChanged_1(object sender, EventArgs e)
        {
            cbo_destinos.Text = "";
            Cbo_DestintosListado();
        }
       

        private void btn_generarInforme_Click(object sender, EventArgs e)
        {
            flagGenerar = true;


            if (cbo_destinos.Text == "")
            {
                dgv_reportes.DataSource = MenuPrincipal.FiltrarListaPasajes(dtp_desde.Value, dtp_hasta.Value);
            }
            else
            {
                dgv_reportes.DataSource = MenuPrincipal.FiltrarListaPasajes(dtp_desde.Value, dtp_hasta.Value, cbo_destinos.Text);
            }
        }

        public void ExportarDatos(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach(DataGridViewColumn columna in dataListado.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow fila in dataListado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach(DataGridViewColumn columna in dataListado.Columns)
                {
                    indiceColumna++;

                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value.ToString();
                }
            }

            exportarExcel.Visible = true;
        }

        private void btx_exportar_Click(object sender, EventArgs e)
        {
            if(flagGenerar)
            {
                ExportarDatos(dgv_reportes);
            }
            else
            {
                MessageBox.Show("Debe generar el reporte primero");
            }
        }
    }
}
