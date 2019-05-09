namespace R2
{
    partial class FormCondicionales
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMayMin = new System.Windows.Forms.Button();
            this.btnVoCo = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnLetra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(6, 19);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 43);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ejercicios de Condicionales";
            // 
            // btnMayMin
            // 
            this.btnMayMin.Location = new System.Drawing.Point(161, 180);
            this.btnMayMin.Name = "btnMayMin";
            this.btnMayMin.Size = new System.Drawing.Size(357, 29);
            this.btnMayMin.TabIndex = 9;
            this.btnMayMin.Text = "Mayúsculas y minúsculas";
            this.btnMayMin.UseVisualStyleBackColor = true;
            this.btnMayMin.Click += new System.EventHandler(this.btnMayMin_Click);
            // 
            // btnVoCo
            // 
            this.btnVoCo.Location = new System.Drawing.Point(11, 145);
            this.btnVoCo.Name = "btnVoCo";
            this.btnVoCo.Size = new System.Drawing.Size(357, 29);
            this.btnVoCo.TabIndex = 8;
            this.btnVoCo.Text = "Comprobar si es vocal o consonante";
            this.btnVoCo.UseVisualStyleBackColor = true;
            this.btnVoCo.Click += new System.EventHandler(this.btnVoCo_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(161, 110);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(357, 29);
            this.btnGeneral.TabIndex = 7;
            this.btnGeneral.Text = "Fórmula general";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnTienda
            // 
            this.btnTienda.Location = new System.Drawing.Point(11, 75);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(357, 29);
            this.btnTienda.TabIndex = 6;
            this.btnTienda.Text = "Tienda llantera";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(12, 215);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(357, 29);
            this.btnMes.TabIndex = 11;
            this.btnMes.Text = "Meses del año";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnLetra
            // 
            this.btnLetra.Location = new System.Drawing.Point(164, 249);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(357, 29);
            this.btnLetra.TabIndex = 12;
            this.btnLetra.Text = "Conversión de un número en letra";
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // FormCondicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMayMin);
            this.Controls.Add(this.btnVoCo);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCondicionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCondicionales_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMayMin;
        private System.Windows.Forms.Button btnVoCo;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnLetra;
    }
}