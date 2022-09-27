namespace Formularios
{
    partial class CargaPersona
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(34, 104);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(34, 160);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(34, 58);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.TabIndex = 2;
            this.lbl_dni.Text = "DNI";
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(154, 219);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtp_fechaNacimiento.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(154, 96);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(195, 23);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(154, 152);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(195, 23);
            this.txt_apellido.TabIndex = 5;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(159, 50);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(195, 23);
            this.txt_dni.TabIndex = 6;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(308, 320);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(93, 320);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 8;
            this.btn_accept.Text = "Aceptar";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // CargaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 384);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "CargaPersona";
            this.Text = "CargaPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_dni;
        private Button btn_cancel;
        private Button btn_accept;
        public DateTimePicker dtp_fechaNacimiento;
        public TextBox txt_nombre;
        public TextBox txt_apellido;
        public TextBox txt_dni;
    }
}