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
            this.SuspendLayout();
            // 
            // lbl_infoPasaje
            // 
            this.lbl_infoPasaje.AutoSize = true;
            this.lbl_infoPasaje.Location = new System.Drawing.Point(35, 24);
            this.lbl_infoPasaje.Name = "lbl_infoPasaje";
            this.lbl_infoPasaje.Size = new System.Drawing.Size(38, 15);
            this.lbl_infoPasaje.TabIndex = 0;
            this.lbl_infoPasaje.Text = "label1";
            // 
            // ImpresionPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 277);
            this.Controls.Add(this.lbl_infoPasaje);
            this.Name = "ImpresionPasaje";
            this.Text = "ImpresionPasaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_infoPasaje;
    }
}