﻿using Entidades;
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
    public partial class ImpresionPasaje : Form
    {
        public ImpresionPasaje(Pasaje aux)
        {
            InitializeComponent();
            lbl_infoPasaje.Text = aux.ToString();
        }
    }
}
