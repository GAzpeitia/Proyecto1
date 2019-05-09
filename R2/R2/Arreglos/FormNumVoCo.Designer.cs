namespace R2
{
    partial class FormNumVoCo
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
            this.btnCal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEscr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumP = new System.Windows.Forms.TextBox();
            this.txtCara = new System.Windows.Forms.TextBox();
            this.txtVoc = new System.Windows.Forms.TextBox();
            this.txtConso = new System.Windows.Forms.TextBox();
            this.btnLim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(38, 202);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(142, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de palabras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carácteres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de vocales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de consonantes:";
            // 
            // txtEscr
            // 
            this.txtEscr.Location = new System.Drawing.Point(86, 23);
            this.txtEscr.Name = "txtEscr";
            this.txtEscr.Size = new System.Drawing.Size(275, 20);
            this.txtEscr.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Escriba aqui:";
            // 
            // txtNumP
            // 
            this.txtNumP.Enabled = false;
            this.txtNumP.Location = new System.Drawing.Point(179, 63);
            this.txtNumP.Name = "txtNumP";
            this.txtNumP.Size = new System.Drawing.Size(48, 20);
            this.txtNumP.TabIndex = 8;
            // 
            // txtCara
            // 
            this.txtCara.Enabled = false;
            this.txtCara.Location = new System.Drawing.Point(179, 93);
            this.txtCara.Name = "txtCara";
            this.txtCara.Size = new System.Drawing.Size(48, 20);
            this.txtCara.TabIndex = 9;
            // 
            // txtVoc
            // 
            this.txtVoc.Enabled = false;
            this.txtVoc.Location = new System.Drawing.Point(179, 124);
            this.txtVoc.Name = "txtVoc";
            this.txtVoc.Size = new System.Drawing.Size(48, 20);
            this.txtVoc.TabIndex = 10;
            // 
            // txtConso
            // 
            this.txtConso.Enabled = false;
            this.txtConso.Location = new System.Drawing.Point(179, 153);
            this.txtConso.Name = "txtConso";
            this.txtConso.Size = new System.Drawing.Size(48, 20);
            this.txtConso.TabIndex = 11;
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(251, 202);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 12;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // FormNumVoCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.txtConso);
            this.Controls.Add(this.txtVoc);
            this.Controls.Add(this.txtCara);
            this.Controls.Add(this.txtNumP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEscr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCal);
            this.Name = "FormNumVoCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNumVoCo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEscr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumP;
        private System.Windows.Forms.TextBox txtCara;
        private System.Windows.Forms.TextBox txtVoc;
        private System.Windows.Forms.TextBox txtConso;
        private System.Windows.Forms.Button btnLim;
    }
}