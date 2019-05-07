namespace R2
{
    partial class FormCali
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
            this.btnSepNom = new System.Windows.Forms.Button();
            this.btnApe = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnSecuencia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSepNom
            // 
            this.btnSepNom.Location = new System.Drawing.Point(12, 183);
            this.btnSepNom.Name = "btnSepNom";
            this.btnSepNom.Size = new System.Drawing.Size(354, 23);
            this.btnSepNom.TabIndex = 12;
            this.btnSepNom.Text = "4. Listar los nombres de estudiantes y sus calificaciones";
            this.btnSepNom.UseVisualStyleBackColor = true;
            // 
            // btnApe
            // 
            this.btnApe.Location = new System.Drawing.Point(12, 125);
            this.btnApe.Name = "btnApe";
            this.btnApe.Size = new System.Drawing.Size(354, 52);
            this.btnApe.TabIndex = 11;
            this.btnApe.Text = "3. Listar todos los nombres de estudiantes que son de una institución en específi" +
    "co";
            this.btnApe.UseVisualStyleBackColor = true;
            // 
            // btnMay
            // 
            this.btnMay.Location = new System.Drawing.Point(12, 74);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(354, 45);
            this.btnMay.TabIndex = 10;
            this.btnMay.Text = "2. Listar todos los nombres de estudiantes que son de una carrera en específico";
            this.btnMay.UseVisualStyleBackColor = true;
            // 
            // btnSecuencia
            // 
            this.btnSecuencia.Location = new System.Drawing.Point(12, 45);
            this.btnSecuencia.Name = "btnSecuencia";
            this.btnSecuencia.Size = new System.Drawing.Size(354, 23);
            this.btnSecuencia.TabIndex = 9;
            this.btnSecuencia.Text = "1. Listar todos los nombres de estudiantes sin ninguna condición";
            this.btnSecuencia.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(103, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormCali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnSepNom);
            this.Controls.Add(this.btnApe);
            this.Controls.Add(this.btnMay);
            this.Controls.Add(this.btnSecuencia);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormCali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCali_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSepNom;
        private System.Windows.Forms.Button btnApe;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnSecuencia;
        private System.Windows.Forms.Button btnSalir;
    }
}