namespace Sistema_de_Gestión_de_Trámites
{
    partial class FrmTramitesGenerales
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrarTramite = new System.Windows.Forms.Button();
            this.btnVerCola = new System.Windows.Forms.Button();
            this.btnAtenderTramite = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoTramite = new System.Windows.Forms.ComboBox();
            this.dataColaTramites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataColaTramites)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO DE TRAMITE";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(186, 89);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(193, 22);
            this.txtDNI.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // btnRegistrarTramite
            // 
            this.btnRegistrarTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.btnRegistrarTramite.Location = new System.Drawing.Point(480, 43);
            this.btnRegistrarTramite.Name = "btnRegistrarTramite";
            this.btnRegistrarTramite.Size = new System.Drawing.Size(151, 44);
            this.btnRegistrarTramite.TabIndex = 6;
            this.btnRegistrarTramite.Text = "REGISTRAR TRAMITE";
            this.btnRegistrarTramite.UseVisualStyleBackColor = false;
            this.btnRegistrarTramite.Click += new System.EventHandler(this.btnRegistrarTramite_Click);
            // 
            // btnVerCola
            // 
            this.btnVerCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.btnVerCola.Location = new System.Drawing.Point(480, 108);
            this.btnVerCola.Name = "btnVerCola";
            this.btnVerCola.Size = new System.Drawing.Size(151, 44);
            this.btnVerCola.TabIndex = 7;
            this.btnVerCola.Text = "VER COLA";
            this.btnVerCola.UseVisualStyleBackColor = false;
            this.btnVerCola.Click += new System.EventHandler(this.btnVerCola_Click_1);
            // 
            // btnAtenderTramite
            // 
            this.btnAtenderTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.btnAtenderTramite.Location = new System.Drawing.Point(480, 176);
            this.btnAtenderTramite.Name = "btnAtenderTramite";
            this.btnAtenderTramite.Size = new System.Drawing.Size(151, 44);
            this.btnAtenderTramite.TabIndex = 8;
            this.btnAtenderTramite.Text = "ATENDER TRAMITE";
            this.btnAtenderTramite.UseVisualStyleBackColor = false;
            this.btnAtenderTramite.Click += new System.EventHandler(this.btnAtenderTramite_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(33, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 33);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Trámites Generales";
            // 
            // cmbTipoTramite
            // 
            this.cmbTipoTramite.FormattingEnabled = true;
            this.cmbTipoTramite.Location = new System.Drawing.Point(185, 176);
            this.cmbTipoTramite.Name = "cmbTipoTramite";
            this.cmbTipoTramite.Size = new System.Drawing.Size(193, 24);
            this.cmbTipoTramite.TabIndex = 10;
            // 
            // dataColaTramites
            // 
            this.dataColaTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataColaTramites.Location = new System.Drawing.Point(29, 251);
            this.dataColaTramites.Name = "dataColaTramites";
            this.dataColaTramites.RowHeadersWidth = 51;
            this.dataColaTramites.RowTemplate.Height = 24;
            this.dataColaTramites.Size = new System.Drawing.Size(777, 227);
            this.dataColaTramites.TabIndex = 11;
            // 
            // FrmTramitesGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(818, 517);
            this.Controls.Add(this.dataColaTramites);
            this.Controls.Add(this.cmbTipoTramite);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAtenderTramite);
            this.Controls.Add(this.btnVerCola);
            this.Controls.Add(this.btnRegistrarTramite);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTramitesGenerales";
            this.Text = "FrmTramitesGenerales";
            this.Load += new System.EventHandler(this.FrmTramitesGenerales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataColaTramites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrarTramite;
        private System.Windows.Forms.Button btnVerCola;
        private System.Windows.Forms.Button btnAtenderTramite;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipoTramite;
        private System.Windows.Forms.DataGridView dataColaTramites;
    }
}