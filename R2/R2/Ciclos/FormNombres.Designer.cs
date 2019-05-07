namespace R2
{
    partial class FormNombres
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSecuencia = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnApe = new System.Windows.Forms.Button();
            this.btnSepNom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(107, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSecuencia
            // 
            this.btnSecuencia.Location = new System.Drawing.Point(12, 57);
            this.btnSecuencia.Name = "btnSecuencia";
            this.btnSecuencia.Size = new System.Drawing.Size(260, 23);
            this.btnSecuencia.TabIndex = 4;
            this.btnSecuencia.Text = "1.Desplegar la lista con número de secuencia";
            this.btnSecuencia.UseVisualStyleBackColor = true;
            this.btnSecuencia.Click += new System.EventHandler(this.btnSecuencia_Click);
            // 
            // btnMay
            // 
            this.btnMay.Location = new System.Drawing.Point(12, 86);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(260, 23);
            this.btnMay.TabIndex = 5;
            this.btnMay.Text = "2.Desplegar con salidas en mayúsculas y listados";
            this.btnMay.UseVisualStyleBackColor = true;
            this.btnMay.Click += new System.EventHandler(this.btnMay_Click);
            // 
            // btnApe
            // 
            this.btnApe.Location = new System.Drawing.Point(12, 115);
            this.btnApe.Name = "btnApe";
            this.btnApe.Size = new System.Drawing.Size(260, 23);
            this.btnApe.TabIndex = 6;
            this.btnApe.Text = "3.Nombre en mayúsculas y apellidos en minúsculas";
            this.btnApe.UseVisualStyleBackColor = true;
            this.btnApe.Click += new System.EventHandler(this.btnApe_Click);
            // 
            // btnSepNom
            // 
            this.btnSepNom.Location = new System.Drawing.Point(12, 144);
            this.btnSepNom.Name = "btnSepNom";
            this.btnSepNom.Size = new System.Drawing.Size(260, 23);
            this.btnSepNom.TabIndex = 7;
            this.btnSepNom.Text = "4.Apellido en mayúsculas separado de su nombre";
            this.btnSepNom.UseVisualStyleBackColor = true;
            this.btnSepNom.Click += new System.EventHandler(this.btnSepNom_Click);
            // 
            // FormNombres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnSepNom);
            this.Controls.Add(this.btnApe);
            this.Controls.Add(this.btnMay);
            this.Controls.Add(this.btnSecuencia);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormNombres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNombres_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSecuencia;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnApe;
        private System.Windows.Forms.Button btnSepNom;
    }
}