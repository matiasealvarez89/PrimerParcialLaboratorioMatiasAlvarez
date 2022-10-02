namespace Formularios
{
    partial class ImpresionPasaje
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
            this.lbl_infoPasaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_infoPasaje
            // 
            this.lbl_infoPasaje.AutoSize = true;
            this.lbl_infoPasaje.Location = new System.Drawing.Point(13, 9);
            this.lbl_infoPasaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_infoPasaje.Name = "lbl_infoPasaje";
            this.lbl_infoPasaje.Size = new System.Drawing.Size(57, 21);
            this.lbl_infoPasaje.TabIndex = 0;
            this.lbl_infoPasaje.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formularios.Properties.Resources.kisspng_leaning_tower_of_pisa_flight_airplane_airline_tick_vector_airplane_tickets_5a96943d86d3c5_4497741515198177895523;
            this.pictureBox1.Location = new System.Drawing.Point(236, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ImpresionPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(374, 214);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_infoPasaje);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImpresionPasaje";
            this.Text = "ImpresionPasaje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_infoPasaje;
        private PictureBox pictureBox1;
    }
}