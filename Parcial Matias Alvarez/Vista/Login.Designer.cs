namespace Formularios
{
    partial class Login
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
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ingreso = new System.Windows.Forms.Label();
            this.btn_autoLogueo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(395, 325);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(180, 23);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(354, 158);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Usuario";
            this.txt_usuario.Size = new System.Drawing.Size(283, 23);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(354, 237);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PlaceholderText = "Contraseña";
            this.txt_pass.Size = new System.Drawing.Size(283, 23);
            this.txt_pass.TabIndex = 2;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(395, 297);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(191, 15);
            this.lbl_error.TabIndex = 3;
            this.lbl_error.Text = "Usuario y/o contraseña incorrectos";
            this.lbl_error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 420);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formularios.Properties.Resources.kisspng_airplane_aircraft_clip_art_airplane_png_clipart_5a7a209ef2d7c1_6834792815179531829947;
            this.pictureBox1.Location = new System.Drawing.Point(12, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ingreso
            // 
            this.lbl_ingreso.AutoSize = true;
            this.lbl_ingreso.Font = new System.Drawing.Font("Carlito", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ingreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ingreso.Location = new System.Drawing.Point(423, 99);
            this.lbl_ingreso.Name = "lbl_ingreso";
            this.lbl_ingreso.Size = new System.Drawing.Size(126, 42);
            this.lbl_ingreso.TabIndex = 5;
            this.lbl_ingreso.Text = "Ingreso";
            // 
            // btn_autoLogueo
            // 
            this.btn_autoLogueo.Location = new System.Drawing.Point(395, 370);
            this.btn_autoLogueo.Name = "btn_autoLogueo";
            this.btn_autoLogueo.Size = new System.Drawing.Size(180, 23);
            this.btn_autoLogueo.TabIndex = 6;
            this.btn_autoLogueo.Text = "AutoLogueo";
            this.btn_autoLogueo.UseVisualStyleBackColor = true;
            this.btn_autoLogueo.Click += new System.EventHandler(this.btn_autoLogueo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(718, 420);
            this.Controls.Add(this.btn_autoLogueo);
            this.Controls.Add(this.lbl_ingreso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Name = "Login";
            this.Opacity = 0.98D;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ingresar;
        private TextBox txt_usuario;
        private TextBox txt_pass;
        private Label lbl_error;
        private Panel panel1;
        private Label lbl_ingreso;
        private Button btn_autoLogueo;
        private PictureBox pictureBox1;
    }
}