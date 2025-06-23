namespace Sistema_de_Gestión_de_Trámites
{
    partial class FrmUrgencias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbTipoTramite = new System.Windows.Forms.ComboBox();
            this.btnAgregarUrgencia = new System.Windows.Forms.Button();
            this.btnAtenderUrgencia = new System.Windows.Forms.Button();
            this.dataUrgencias = new System.Windows.Forms.DataGridView();
            this.btnVerPila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUrgencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Urgencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "MOTIVO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIPO DE TRAMITE";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(198, 76);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(201, 22);
            this.txtDNI.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(198, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(198, 172);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(201, 22);
            this.txtMotivo.TabIndex = 7;
            // 
            // cmbTipoTramite
            // 
            this.cmbTipoTramite.FormattingEnabled = true;
            this.cmbTipoTramite.Location = new System.Drawing.Point(198, 220);
            this.cmbTipoTramite.Name = "cmbTipoTramite";
            this.cmbTipoTramite.Size = new System.Drawing.Size(201, 24);
            this.cmbTipoTramite.TabIndex = 8;
            // 
            // btnAgregarUrgencia
            // 
            this.btnAgregarUrgencia.Location = new System.Drawing.Point(472, 76);
            this.btnAgregarUrgencia.Name = "btnAgregarUrgencia";
            this.btnAgregarUrgencia.Size = new System.Drawing.Size(151, 44);
            this.btnAgregarUrgencia.TabIndex = 9;
            this.btnAgregarUrgencia.Text = "AGREGAR URGENCIA";
            this.btnAgregarUrgencia.UseVisualStyleBackColor = true;
            this.btnAgregarUrgencia.Click += new System.EventHandler(this.btnAgregarUrgencia_Click);
            // 
            // btnAtenderUrgencia
            // 
            this.btnAtenderUrgencia.Location = new System.Drawing.Point(472, 144);
            this.btnAtenderUrgencia.Name = "btnAtenderUrgencia";
            this.btnAtenderUrgencia.Size = new System.Drawing.Size(151, 44);
            this.btnAtenderUrgencia.TabIndex = 10;
            this.btnAtenderUrgencia.Text = "ATENDER URGENCIA";
            this.btnAtenderUrgencia.UseVisualStyleBackColor = true;
            this.btnAtenderUrgencia.Click += new System.EventHandler(this.btnAtenderUrgencia_Click);
            // 
            // dataUrgencias
            // 
            this.dataUrgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUrgencias.Location = new System.Drawing.Point(18, 275);
            this.dataUrgencias.Name = "dataUrgencias";
            this.dataUrgencias.RowHeadersWidth = 51;
            this.dataUrgencias.RowTemplate.Height = 24;
            this.dataUrgencias.Size = new System.Drawing.Size(839, 202);
            this.dataUrgencias.TabIndex = 11;
            // 
            // btnVerPila
            // 
            this.btnVerPila.Location = new System.Drawing.Point(472, 209);
            this.btnVerPila.Name = "btnVerPila";
            this.btnVerPila.Size = new System.Drawing.Size(151, 44);
            this.btnVerPila.TabIndex = 12;
            this.btnVerPila.Text = "VER PILA";
            this.btnVerPila.UseVisualStyleBackColor = true;
            this.btnVerPila.Click += new System.EventHandler(this.btnVerPila_Click);
            // 
            // FrmUrgencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(882, 518);
            this.Controls.Add(this.btnVerPila);
            this.Controls.Add(this.dataUrgencias);
            this.Controls.Add(this.btnAtenderUrgencia);
            this.Controls.Add(this.btnAgregarUrgencia);
            this.Controls.Add(this.cmbTipoTramite);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUrgencias";
            this.Text = "FrmUrgencias";
            this.Load += new System.EventHandler(this.FrmUrgencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUrgencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cmbTipoTramite;
        private System.Windows.Forms.Button btnAgregarUrgencia;
        private System.Windows.Forms.Button btnAtenderUrgencia;
        private System.Windows.Forms.DataGridView dataUrgencias;
        private System.Windows.Forms.Button btnVerPila;
    }
}