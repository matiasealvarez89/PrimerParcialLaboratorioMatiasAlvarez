namespace Formularios
{
    partial class CargaVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_idVuelo = new System.Windows.Forms.Label();
            this.txt_idVuelo = new System.Windows.Forms.TextBox();
            this.chk_internacional = new System.Windows.Forms.CheckBox();
            this.cbo_destinos = new System.Windows.Forms.ComboBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.cbo_aviones = new System.Windows.Forms.ComboBox();
            this.lbl_avion = new System.Windows.Forms.Label();
            this.mca_fecha = new System.Windows.Forms.MonthCalendar();
            this.btn_cargarVelo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_idVuelo
            // 
            this.lbl_idVuelo.AutoSize = true;
            this.lbl_idVuelo.Location = new System.Drawing.Point(9, 12);
            this.lbl_idVuelo.Name = "lbl_idVuelo";
            this.lbl_idVuelo.Size = new System.Drawing.Size(50, 15);
            this.lbl_idVuelo.TabIndex = 0;
            this.lbl_idVuelo.Text = "Id Vuelo";
            // 
            // txt_idVuelo
            // 
            this.txt_idVuelo.Location = new System.Drawing.Point(68, 4);
            this.txt_idVuelo.MaxLength = 6;
            this.txt_idVuelo.Name = "txt_idVuelo";
            this.txt_idVuelo.Size = new System.Drawing.Size(192, 23);
            this.txt_idVuelo.TabIndex = 1;
            // 
            // chk_internacional
            // 
            this.chk_internacional.AutoSize = true;
            this.chk_internacional.Location = new System.Drawing.Point(12, 30);
            this.chk_internacional.Name = "chk_internacional";
            this.chk_internacional.Size = new System.Drawing.Size(95, 19);
            this.chk_internacional.TabIndex = 2;
            this.chk_internacional.Text = "Internacional";
            this.chk_internacional.UseVisualStyleBackColor = true;
            this.chk_internacional.CheckedChanged += new System.EventHandler(this.chk_internacional_CheckedChanged);
            // 
            // cbo_destinos
            // 
            this.cbo_destinos.FormattingEnabled = true;
            this.cbo_destinos.Location = new System.Drawing.Point(68, 55);
            this.cbo_destinos.Name = "cbo_destinos";
            this.cbo_destinos.Size = new System.Drawing.Size(192, 23);
            this.cbo_destinos.TabIndex = 3;
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(12, 58);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(47, 15);
            this.lbl_destino.TabIndex = 4;
            this.lbl_destino.Text = "Destino";
            // 
            // cbo_aviones
            // 
            this.cbo_aviones.FormattingEnabled = true;
            this.cbo_aviones.Location = new System.Drawing.Point(68, 84);
            this.cbo_aviones.Name = "cbo_aviones";
            this.cbo_aviones.Size = new System.Drawing.Size(192, 23);
            this.cbo_aviones.TabIndex = 5;
            // 
            // lbl_avion
            // 
            this.lbl_avion.AutoSize = true;
            this.lbl_avion.Location = new System.Drawing.Point(12, 87);
            this.lbl_avion.Name = "lbl_avion";
            this.lbl_avion.Size = new System.Drawing.Size(38, 15);
            this.lbl_avion.TabIndex = 6;
            this.lbl_avion.Text = "Avion";
            // 
            // mca_fecha
            // 
            this.mca_fecha.Location = new System.Drawing.Point(12, 142);
            this.mca_fecha.MinDate = new System.DateTime(2022, 10, 2, 13, 31, 44, 0);
            this.mca_fecha.Name = "mca_fecha";
            this.mca_fecha.TabIndex = 7;
            // 
            // btn_cargarVelo
            // 
            this.btn_cargarVelo.Location = new System.Drawing.Point(12, 316);
            this.btn_cargarVelo.Name = "btn_cargarVelo";
            this.btn_cargarVelo.Size = new System.Drawing.Size(95, 37);
            this.btn_cargarVelo.TabIndex = 8;
            this.btn_cargarVelo.Text = "Cargar Vuelo";
            this.btn_cargarVelo.UseVisualStyleBackColor = true;
            this.btn_cargarVelo.Click += new System.EventHandler(this.btn_cargarVelo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(165, 316);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 37);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CargaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cargarVelo);
            this.Controls.Add(this.mca_fecha);
            this.Controls.Add(this.lbl_avion);
            this.Controls.Add(this.cbo_aviones);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.cbo_destinos);
            this.Controls.Add(this.chk_internacional);
            this.Controls.Add(this.txt_idVuelo);
            this.Controls.Add(this.lbl_idVuelo);
            this.Name = "CargaVuelo";
            this.Text = "CargaVuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_idVuelo;
        private TextBox txt_idVuelo;
        private CheckBox chk_internacional;
        private ComboBox cbo_destinos;
        private Label lbl_destino;
        private ComboBox cbo_aviones;
        private Label lbl_avion;
        private MonthCalendar mca_fecha;
        private Button btn_cargarVelo;
        private Button btn_cancelar;        
    }
}