﻿namespace R2
{
    partial class FormHipotenusa
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
            this.txtRes2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richRes = new System.Windows.Forms.RichTextBox();
            this.txtRes1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRes2
            // 
            this.txtRes2.Location = new System.Drawing.Point(39, 123);
            this.txtRes2.Name = "txtRes2";
            this.txtRes2.Size = new System.Drawing.Size(134, 20);
            this.txtRes2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ingrese el valor del cateto adyasente (b):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ingrese el valor del cateto opuesto (a):";
            // 
            // richRes
            // 
            this.richRes.Location = new System.Drawing.Point(39, 162);
            this.richRes.Name = "richRes";
            this.richRes.Size = new System.Drawing.Size(217, 104);
            this.richRes.TabIndex = 45;
            this.richRes.Text = "";
            // 
            // txtRes1
            // 
            this.txtRes1.Location = new System.Drawing.Point(39, 63);
            this.txtRes1.Name = "txtRes1";
            this.txtRes1.Size = new System.Drawing.Size(134, 20);
            this.txtRes1.TabIndex = 44;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(283, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(283, 160);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 42;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(283, 243);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 49;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // FormHipotenusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(376, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.txtRes2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richRes);
            this.Controls.Add(this.txtRes1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCal);
            this.Name = "FormHipotenusa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormHipotenusa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRes2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richRes;
        private System.Windows.Forms.TextBox txtRes1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnLim;
    }
}