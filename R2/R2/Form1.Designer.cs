namespace R2
{
    partial class Form1
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
            this.comboElegir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboElegir
            // 
            this.comboElegir.FormattingEnabled = true;
            this.comboElegir.Items.AddRange(new object[] {
            "Arreglos",
            "Ciclos",
            "Condicionales",
            "Funciones",
            "Secuenciales"});
            this.comboElegir.Location = new System.Drawing.Point(59, 79);
            this.comboElegir.Name = "comboElegir";
            this.comboElegir.Size = new System.Drawing.Size(132, 21);
            this.comboElegir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eliga una opción";
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(40, 127);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 2;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(130, 127);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(244, 197);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboElegir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboElegir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnSalir;
    }
}

