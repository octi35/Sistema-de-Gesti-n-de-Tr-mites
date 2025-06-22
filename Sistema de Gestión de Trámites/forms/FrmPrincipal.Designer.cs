namespace Sistema_de_Gestión_de_Trámites
{
    partial class FrmPrincipal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTramites = new System.Windows.Forms.TabPage();
            this.tabUrgencias = new System.Windows.Forms.TabPage();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.tabSimulacion = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTramites);
            this.tabControl1.Controls.Add(this.tabUrgencias);
            this.tabControl1.Controls.Add(this.tabHistorial);
            this.tabControl1.Controls.Add(this.tabSimulacion);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTramites
            // 
            this.tabTramites.Location = new System.Drawing.Point(4, 25);
            this.tabTramites.Name = "tabTramites";
            this.tabTramites.Padding = new System.Windows.Forms.Padding(3);
            this.tabTramites.Size = new System.Drawing.Size(899, 561);
            this.tabTramites.TabIndex = 0;
            this.tabTramites.Text = "TRAMITES";
            this.tabTramites.UseVisualStyleBackColor = true;
            // 
            // tabUrgencias
            // 
            this.tabUrgencias.Location = new System.Drawing.Point(4, 25);
            this.tabUrgencias.Name = "tabUrgencias";
            this.tabUrgencias.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrgencias.Size = new System.Drawing.Size(899, 561);
            this.tabUrgencias.TabIndex = 1;
            this.tabUrgencias.Text = "URGENCIAS";
            this.tabUrgencias.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Location = new System.Drawing.Point(4, 25);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(899, 561);
            this.tabHistorial.TabIndex = 2;
            this.tabHistorial.Text = "HISTORIAL";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // tabSimulacion
            // 
            this.tabSimulacion.Location = new System.Drawing.Point(4, 25);
            this.tabSimulacion.Name = "tabSimulacion";
            this.tabSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimulacion.Size = new System.Drawing.Size(899, 561);
            this.tabSimulacion.TabIndex = 3;
            this.tabSimulacion.Text = "SIMULACION";
            this.tabSimulacion.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 642);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTramites;
        private System.Windows.Forms.TabPage tabUrgencias;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabSimulacion;
    }
}

