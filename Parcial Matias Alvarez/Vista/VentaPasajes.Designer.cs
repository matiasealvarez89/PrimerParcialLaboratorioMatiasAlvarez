namespace Formularios
{
    partial class VentaPasajes
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
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.cbo_destino = new System.Windows.Forms.ComboBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.chk_internacional = new System.Windows.Forms.CheckBox();
            this.lbl_seleccioneVuelo = new System.Windows.Forms.Label();
            this.cbo_vuelo = new System.Windows.Forms.ComboBox();
            this.chk_esPremium = new System.Windows.Forms.CheckBox();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.cbo_cantidadValijas = new System.Windows.Forms.ComboBox();
            this.lbl_cantidadValijas = new System.Windows.Forms.Label();
            this.txt_peso1 = new System.Windows.Forms.TextBox();
            this.txt_peso2 = new System.Windows.Forms.TextBox();
            this.btn_comprarPasaje = new System.Windows.Forms.Button();
            this.btn_comprarMasPasajes = new System.Windows.Forms.Button();
            this.chk_cargarValijasDespues = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(12, 30);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(86, 22);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 23);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(86, 65);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 113);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 157);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // cbo_destino
            // 
            this.cbo_destino.FormattingEnabled = true;
            this.cbo_destino.Location = new System.Drawing.Point(91, 210);
            this.cbo_destino.Name = "cbo_destino";
            this.cbo_destino.Size = new System.Drawing.Size(121, 23);
            this.cbo_destino.TabIndex = 6;
            this.cbo_destino.SelectedIndexChanged += new System.EventHandler(this.cbo_destino_SelectedIndexChanged);
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(12, 218);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(47, 15);
            this.lbl_destino.TabIndex = 7;
            this.lbl_destino.Text = "Destino";
            // 
            // chk_internacional
            // 
            this.chk_internacional.AutoSize = true;
            this.chk_internacional.Location = new System.Drawing.Point(91, 184);
            this.chk_internacional.Name = "chk_internacional";
            this.chk_internacional.Size = new System.Drawing.Size(95, 19);
            this.chk_internacional.TabIndex = 8;
            this.chk_internacional.Text = "Internacional";
            this.chk_internacional.UseVisualStyleBackColor = true;
            this.chk_internacional.CheckedChanged += new System.EventHandler(this.chk_internacional_CheckedChanged);
            // 
            // lbl_seleccioneVuelo
            // 
            this.lbl_seleccioneVuelo.AutoSize = true;
            this.lbl_seleccioneVuelo.Location = new System.Drawing.Point(12, 277);
            this.lbl_seleccioneVuelo.Name = "lbl_seleccioneVuelo";
            this.lbl_seleccioneVuelo.Size = new System.Drawing.Size(107, 15);
            this.lbl_seleccioneVuelo.TabIndex = 9;
            this.lbl_seleccioneVuelo.Text = "Seleccione el vuelo";
            // 
            // cbo_vuelo
            // 
            this.cbo_vuelo.FormattingEnabled = true;
            this.cbo_vuelo.Location = new System.Drawing.Point(12, 305);
            this.cbo_vuelo.Name = "cbo_vuelo";
            this.cbo_vuelo.Size = new System.Drawing.Size(277, 23);
            this.cbo_vuelo.TabIndex = 10;
            // 
            // chk_esPremium
            // 
            this.chk_esPremium.AutoSize = true;
            this.chk_esPremium.Location = new System.Drawing.Point(12, 351);
            this.chk_esPremium.Name = "chk_esPremium";
            this.chk_esPremium.Size = new System.Drawing.Size(89, 19);
            this.chk_esPremium.TabIndex = 11;
            this.chk_esPremium.Text = "Es Premium";
            this.chk_esPremium.UseVisualStyleBackColor = true;
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.Location = new System.Drawing.Point(12, 406);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(125, 32);
            this.btn_cotizar.TabIndex = 12;
            this.btn_cotizar.Text = "Cotizar";
            this.btn_cotizar.UseVisualStyleBackColor = true;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.Location = new System.Drawing.Point(402, 55);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(84, 32);
            this.lbl_precio.TabIndex = 13;
            this.lbl_precio.Text = "Precio:";
            // 
            // cbo_cantidadValijas
            // 
            this.cbo_cantidadValijas.Enabled = false;
            this.cbo_cantidadValijas.FormattingEnabled = true;
            this.cbo_cantidadValijas.Location = new System.Drawing.Point(514, 202);
            this.cbo_cantidadValijas.Name = "cbo_cantidadValijas";
            this.cbo_cantidadValijas.Size = new System.Drawing.Size(36, 23);
            this.cbo_cantidadValijas.TabIndex = 14;
            this.cbo_cantidadValijas.SelectedIndexChanged += new System.EventHandler(this.cbo_cantidadValijas_SelectedIndexChanged);
            // 
            // lbl_cantidadValijas
            // 
            this.lbl_cantidadValijas.AutoSize = true;
            this.lbl_cantidadValijas.Location = new System.Drawing.Point(402, 210);
            this.lbl_cantidadValijas.Name = "lbl_cantidadValijas";
            this.lbl_cantidadValijas.Size = new System.Drawing.Size(106, 15);
            this.lbl_cantidadValijas.TabIndex = 15;
            this.lbl_cantidadValijas.Text = "Cantidad de Valijas";
            // 
            // txt_peso1
            // 
            this.txt_peso1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_peso1.Location = new System.Drawing.Point(594, 207);
            this.txt_peso1.MaxLength = 2;
            this.txt_peso1.Name = "txt_peso1";
            this.txt_peso1.PlaceholderText = "Ingrese el peso (Kg)";
            this.txt_peso1.Size = new System.Drawing.Size(124, 23);
            this.txt_peso1.TabIndex = 16;
            // 
            // txt_peso2
            // 
            this.txt_peso2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_peso2.Location = new System.Drawing.Point(594, 246);
            this.txt_peso2.MaxLength = 2;
            this.txt_peso2.Name = "txt_peso2";
            this.txt_peso2.PlaceholderText = "Ingrese el peso (Kg)";
            this.txt_peso2.Size = new System.Drawing.Size(124, 23);
            this.txt_peso2.TabIndex = 17;
            this.txt_peso2.Visible = false;
            // 
            // btn_comprarPasaje
            // 
            this.btn_comprarPasaje.Location = new System.Drawing.Point(402, 398);
            this.btn_comprarPasaje.Name = "btn_comprarPasaje";
            this.btn_comprarPasaje.Size = new System.Drawing.Size(132, 40);
            this.btn_comprarPasaje.TabIndex = 18;
            this.btn_comprarPasaje.Text = "Comprar";
            this.btn_comprarPasaje.UseVisualStyleBackColor = true;
            this.btn_comprarPasaje.Click += new System.EventHandler(this.btn_comprarPasaje_Click);
            // 
            // btn_comprarMasPasajes
            // 
            this.btn_comprarMasPasajes.Location = new System.Drawing.Point(594, 398);
            this.btn_comprarMasPasajes.Name = "btn_comprarMasPasajes";
            this.btn_comprarMasPasajes.Size = new System.Drawing.Size(132, 40);
            this.btn_comprarMasPasajes.TabIndex = 19;
            this.btn_comprarMasPasajes.Text = "Comprar mas pasajes";
            this.btn_comprarMasPasajes.UseVisualStyleBackColor = true;
            this.btn_comprarMasPasajes.Click += new System.EventHandler(this.btn_comprarMasPasajes_Click);
            // 
            // chk_cargarValijasDespues
            // 
            this.chk_cargarValijasDespues.AutoSize = true;
            this.chk_cargarValijasDespues.Location = new System.Drawing.Point(402, 250);
            this.chk_cargarValijasDespues.Name = "chk_cargarValijasDespues";
            this.chk_cargarValijasDespues.Size = new System.Drawing.Size(161, 19);
            this.chk_cargarValijasDespues.TabIndex = 20;
            this.chk_cargarValijasDespues.Text = "Cargar valijas en Check In";
            this.chk_cargarValijasDespues.UseVisualStyleBackColor = true;
            this.chk_cargarValijasDespues.CheckedChanged += new System.EventHandler(this.chk_cargarValijasDespues_CheckedChanged);
            // 
            // VentaPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.chk_cargarValijasDespues);
            this.Controls.Add(this.btn_comprarMasPasajes);
            this.Controls.Add(this.btn_comprarPasaje);
            this.Controls.Add(this.txt_peso2);
            this.Controls.Add(this.txt_peso1);
            this.Controls.Add(this.lbl_cantidadValijas);
            this.Controls.Add(this.cbo_cantidadValijas);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.btn_cotizar);
            this.Controls.Add(this.chk_esPremium);
            this.Controls.Add(this.cbo_vuelo);
            this.Controls.Add(this.lbl_seleccioneVuelo);
            this.Controls.Add(this.chk_internacional);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.cbo_destino);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_dni);
            this.Name = "VentaPasajes";
            this.Text = "VentaPasajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_dni;
        private TextBox txt_dni;
        private Button btn_consultar;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private ComboBox cbo_destino;
        private Label lbl_destino;
        private CheckBox chk_internacional;
        private Label lbl_seleccioneVuelo;
        private ComboBox cbo_vuelo;
        private CheckBox chk_esPremium;
        private Button btn_cotizar;
        private Label lbl_precio;
        private ComboBox cbo_cantidadValijas;
        private Label lbl_cantidadValijas;
        private TextBox txt_peso1;
        private TextBox txt_peso2;
        private Button btn_comprarPasaje;
        private Button btn_comprarMasPasajes;
        private CheckBox chk_cargarValijasDespues;
    }
}