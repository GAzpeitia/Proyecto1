namespace R2
{
    partial class FormNumMayMin
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
            this.txtNumMay = new System.Windows.Forms.TextBox();
            this.txtNumMin = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listNum = new System.Windows.Forms.ListBox();
            this.btnLim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número mayor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número menor:";
            // 
            // txtNumMay
            // 
            this.txtNumMay.Enabled = false;
            this.txtNumMay.Location = new System.Drawing.Point(96, 38);
            this.txtNumMay.Name = "txtNumMay";
            this.txtNumMay.Size = new System.Drawing.Size(100, 20);
            this.txtNumMay.TabIndex = 2;
            // 
            // txtNumMin
            // 
            this.txtNumMin.Enabled = false;
            this.txtNumMin.Location = new System.Drawing.Point(96, 73);
            this.txtNumMin.Name = "txtNumMin";
            this.txtNumMin.Size = new System.Drawing.Size(100, 20);
            this.txtNumMin.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(15, 142);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listNum
            // 
            this.listNum.FormattingEnabled = true;
            this.listNum.Location = new System.Drawing.Point(159, 99);
            this.listNum.Name = "listNum";
            this.listNum.Size = new System.Drawing.Size(172, 147);
            this.listNum.TabIndex = 6;
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(16, 226);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 7;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // FormNumMayMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.listNum);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtNumMin);
            this.Controls.Add(this.txtNumMay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNumMayMin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNumMayMin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumMay;
        private System.Windows.Forms.TextBox txtNumMin;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listNum;
        private System.Windows.Forms.Button btnLim;
    }
}