namespace Formularios
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.btn_venderPasajes = new System.Windows.Forms.Button();
            this.btn_cargarPersona = new System.Windows.Forms.Button();
            this.dgv_listadoVuelos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lbl_nombreUsuario);
            this.panel1.Controls.Add(this.btn_venderPasajes);
            this.panel1.Controls.Add(this.btn_cargarPersona);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 450);
            this.panel1.TabIndex = 0;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(3, 423);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(30, 15);
            this.lbl_nombreUsuario.TabIndex = 3;
            this.lbl_nombreUsuario.Text = "User";
            // 
            // btn_venderPasajes
            // 
            this.btn_venderPasajes.Location = new System.Drawing.Point(28, 178);
            this.btn_venderPasajes.Name = "btn_venderPasajes";
            this.btn_venderPasajes.Size = new System.Drawing.Size(122, 42);
            this.btn_venderPasajes.TabIndex = 2;
            this.btn_venderPasajes.Text = "Vender Pasajes";
            this.btn_venderPasajes.UseVisualStyleBackColor = true;
            // 
            // btn_cargarPersona
            // 
            this.btn_cargarPersona.Location = new System.Drawing.Point(28, 97);
            this.btn_cargarPersona.Name = "btn_cargarPersona";
            this.btn_cargarPersona.Size = new System.Drawing.Size(122, 42);
            this.btn_cargarPersona.TabIndex = 1;
            this.btn_cargarPersona.Text = "Cargar Persona";
            this.btn_cargarPersona.UseVisualStyleBackColor = true;
            this.btn_cargarPersona.Click += new System.EventHandler(this.btn_cargarPersona_Click);
            // 
            // dgv_listadoVuelos
            // 
            this.dgv_listadoVuelos.AllowUserToAddRows = false;
            this.dgv_listadoVuelos.AllowUserToDeleteRows = false;
            this.dgv_listadoVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoVuelos.Location = new System.Drawing.Point(170, 217);
            this.dgv_listadoVuelos.Name = "dgv_listadoVuelos";
            this.dgv_listadoVuelos.ReadOnly = true;
            this.dgv_listadoVuelos.RowTemplate.Height = 25;
            this.dgv_listadoVuelos.Size = new System.Drawing.Size(978, 221);
            this.dgv_listadoVuelos.TabIndex = 4;
            this.dgv_listadoVuelos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_listadoVuelos_CellFormatting);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.dgv_listadoVuelos);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_venderPasajes;
        private Button btn_cargarPersona;
        private Label lbl_nombreUsuario;
        private DataGridView dgv_listadoVuelos;
    }
}