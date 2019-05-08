namespace R2
{
    partial class FormFunciones
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
            this.btnCom = new System.Windows.Forms.Button();
            this.btnAmi = new System.Windows.Forms.Button();
            this.btnPerf = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(6, 19);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 75);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ejercicios de Funciones";
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(164, 180);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(357, 29);
            this.btnCom.TabIndex = 9;
            this.btnCom.Text = "Números combinatorios";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnAmi
            // 
            this.btnAmi.Location = new System.Drawing.Point(14, 145);
            this.btnAmi.Name = "btnAmi";
            this.btnAmi.Size = new System.Drawing.Size(357, 29);
            this.btnAmi.TabIndex = 8;
            this.btnAmi.Text = "Números amigos";
            this.btnAmi.UseVisualStyleBackColor = true;
            this.btnAmi.Click += new System.EventHandler(this.btnAmi_Click);
            // 
            // btnPerf
            // 
            this.btnPerf.Location = new System.Drawing.Point(164, 110);
            this.btnPerf.Name = "btnPerf";
            this.btnPerf.Size = new System.Drawing.Size(357, 29);
            this.btnPerf.TabIndex = 7;
            this.btnPerf.Text = "Número perfecto";
            this.btnPerf.UseVisualStyleBackColor = true;
            this.btnPerf.Click += new System.EventHandler(this.btnPerf_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(14, 75);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(357, 29);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "División";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // FormFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 357);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnAmi);
            this.Controls.Add(this.btnPerf);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormFunciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnAmi;
        private System.Windows.Forms.Button btnPerf;
        private System.Windows.Forms.Button btnDiv;
    }
}