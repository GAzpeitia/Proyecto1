﻿namespace R2
{
    partial class FormValorAbsoluto
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
            this.richRes = new System.Windows.Forms.RichTextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese un valor";
            // 
            // richRes
            // 
            this.richRes.Location = new System.Drawing.Point(12, 85);
            this.richRes.Name = "richRes";
            this.richRes.Size = new System.Drawing.Size(260, 96);
            this.richRes.TabIndex = 9;
            this.richRes.Text = "";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(101, 33);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(101, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(12, 214);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(198, 214);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 22;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // FormValorAbsoluto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richRes);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCal);
            this.Name = "FormValorAbsoluto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richRes;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnLim;
    }
}