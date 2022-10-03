namespace Formularios
{
    partial class Informes
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
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.chk_internacional = new System.Windows.Forms.CheckBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.cbo_destinos = new System.Windows.Forms.ComboBox();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dgv_reportes = new System.Windows.Forms.DataGridView();
            this.btn_generarInforme = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_recaudacion = new System.Windows.Forms.Label();
            this.btx_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(12, 32);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(39, 15);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(12, 88);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(37, 15);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Hasta";
            // 
            // chk_internacional
            // 
            this.chk_internacional.AutoSize = true;
            this.chk_internacional.Location = new System.Drawing.Point(12, 138);
            this.chk_internacional.Name = "chk_internacional";
            this.chk_internacional.Size = new System.Drawing.Size(95, 19);
            this.chk_internacional.TabIndex = 3;
            this.chk_internacional.Text = "Internacional";
            this.chk_internacional.UseVisualStyleBackColor = true;
            this.chk_internacional.CheckedChanged += new System.EventHandler(this.chk_internacional_CheckedChanged_1);
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(12, 187);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(47, 15);
            this.lbl_destino.TabIndex = 5;
            this.lbl_destino.Text = "Destino";
            // 
            // cbo_destinos
            // 
            this.cbo_destinos.FormattingEnabled = true;
            this.cbo_destinos.Location = new System.Drawing.Point(74, 179);
            this.cbo_destinos.Name = "cbo_destinos";
            this.cbo_destinos.Size = new System.Drawing.Size(118, 23);
            this.cbo_destinos.TabIndex = 6;
            // 
            // dtp_desde
            // 
            this.dtp_desde.Location = new System.Drawing.Point(55, 26);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(137, 23);
            this.dtp_desde.TabIndex = 7;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(55, 80);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(137, 23);
            this.dtp_hasta.TabIndex = 8;
            // 
            // dgv_reportes
            // 
            this.dgv_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reportes.Location = new System.Drawing.Point(232, 26);
            this.dgv_reportes.Name = "dgv_reportes";
            this.dgv_reportes.RowTemplate.Height = 25;
            this.dgv_reportes.Size = new System.Drawing.Size(556, 210);
            this.dgv_reportes.TabIndex = 9;
            // 
            // btn_generarInforme
            // 
            this.btn_generarInforme.Location = new System.Drawing.Point(12, 284);
            this.btn_generarInforme.Name = "btn_generarInforme";
            this.btn_generarInforme.Size = new System.Drawing.Size(75, 23);
            this.btn_generarInforme.TabIndex = 12;
            this.btn_generarInforme.Text = "Generar Informe";
            this.btn_generarInforme.UseVisualStyleBackColor = true;
            this.btn_generarInforme.Click += new System.EventHandler(this.btn_generarInforme_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(713, 284);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_recaudacion
            // 
            this.lbl_recaudacion.AutoSize = true;
            this.lbl_recaudacion.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_recaudacion.Location = new System.Drawing.Point(232, 239);
            this.lbl_recaudacion.Name = "lbl_recaudacion";
            this.lbl_recaudacion.Size = new System.Drawing.Size(226, 24);
            this.lbl_recaudacion.TabIndex = 14;
            this.lbl_recaudacion.Text = "Recaudacion Total: U$S";
            // 
            // btx_exportar
            // 
            this.btx_exportar.Location = new System.Drawing.Point(713, 239);
            this.btx_exportar.Name = "btx_exportar";
            this.btx_exportar.Size = new System.Drawing.Size(75, 23);
            this.btx_exportar.TabIndex = 15;
            this.btx_exportar.Text = "Exportar";
            this.btx_exportar.UseVisualStyleBackColor = true;
            this.btx_exportar.Click += new System.EventHandler(this.btx_exportar_Click);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.ControlBox = false;
            this.Controls.Add(this.btx_exportar);
            this.Controls.Add(this.lbl_recaudacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_generarInforme);
            this.Controls.Add(this.dgv_reportes);
            this.Controls.Add(this.dtp_hasta);
            this.Controls.Add(this.dtp_desde);
            this.Controls.Add(this.cbo_destinos);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.chk_internacional);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_desde);
            this.Name = "Informes";
            this.Text = "Informes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_desde;
        private Label lbl_hasta;
        private CheckBox chk_internacional;
        private Label lbl_destino;
        private ComboBox cbo_destinos;
        private DateTimePicker dtp_desde;
        private DateTimePicker dtp_hasta;
        private DataGridView dgv_reportes;
        private Button btn_generarInforme;
        private Button btn_cancelar;
        private Label lbl_recaudacion;
        private Button btx_exportar;
    }
}