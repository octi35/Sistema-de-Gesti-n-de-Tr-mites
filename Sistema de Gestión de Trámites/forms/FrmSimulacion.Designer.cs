namespace Sistema_de_Gestión_de_Trámites
{
    partial class FrmSimulacion
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
            this.btnAbrirJornada = new System.Windows.Forms.Button();
            this.btnCerrarJornada = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION JORNDA";
            // 
            // btnAbrirJornada
            // 
            this.btnAbrirJornada.Location = new System.Drawing.Point(47, 307);
            this.btnAbrirJornada.Name = "btnAbrirJornada";
            this.btnAbrirJornada.Size = new System.Drawing.Size(224, 52);
            this.btnAbrirJornada.TabIndex = 1;
            this.btnAbrirJornada.Text = "ABRIR JORNADA";
            this.btnAbrirJornada.UseVisualStyleBackColor = true;
            this.btnAbrirJornada.Click += new System.EventHandler(this.btnAbrirJornada_Click);
            // 
            // btnCerrarJornada
            // 
            this.btnCerrarJornada.Location = new System.Drawing.Point(410, 307);
            this.btnCerrarJornada.Name = "btnCerrarJornada";
            this.btnCerrarJornada.Size = new System.Drawing.Size(216, 52);
            this.btnCerrarJornada.TabIndex = 2;
            this.btnCerrarJornada.Text = "CERRAR JORNADA";
            this.btnCerrarJornada.UseVisualStyleBackColor = true;
            this.btnCerrarJornada.Click += new System.EventHandler(this.btnCerrarJornada_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(196, 155);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(101, 36);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "label2";
            // 
            // FrmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCerrarJornada);
            this.Controls.Add(this.btnAbrirJornada);
            this.Controls.Add(this.label1);
            this.Name = "FrmSimulacion";
            this.Text = "FrmSimulacion";
            this.Load += new System.EventHandler(this.FrmSimulacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirJornada;
        private System.Windows.Forms.Button btnCerrarJornada;
        private System.Windows.Forms.Label lblEstado;
    }
}