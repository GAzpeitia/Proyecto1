namespace R2
{
    partial class FormListAlu
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
            this.btnLista1 = new System.Windows.Forms.Button();
            this.btnLista2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLista1
            // 
            this.btnLista1.Location = new System.Drawing.Point(33, 71);
            this.btnLista1.Name = "btnLista1";
            this.btnLista1.Size = new System.Drawing.Size(209, 42);
            this.btnLista1.TabIndex = 0;
            this.btnLista1.Text = "Almacenar todos los nombres leídos en un arreglo y también la carrera";
            this.btnLista1.UseVisualStyleBackColor = true;
            this.btnLista1.Click += new System.EventHandler(this.btnLista1_Click);
            // 
            // btnLista2
            // 
            this.btnLista2.Location = new System.Drawing.Point(33, 129);
            this.btnLista2.Name = "btnLista2";
            this.btnLista2.Size = new System.Drawing.Size(209, 42);
            this.btnLista2.TabIndex = 1;
            this.btnLista2.Text = "Listar todos los nombres almacenados desde el arreglo junto con su carrera";
            this.btnLista2.UseVisualStyleBackColor = true;
            this.btnLista2.Click += new System.EventHandler(this.btnLista2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.btnRegre);
            this.groupBox1.Location = new System.Drawing.Point(22, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnRegre
            // 
            this.btnRegre.Location = new System.Drawing.Point(20, 19);
            this.btnRegre.Name = "btnRegre";
            this.btnRegre.Size = new System.Drawing.Size(200, 23);
            this.btnRegre.TabIndex = 0;
            this.btnRegre.Text = "Regresar";
            this.btnRegre.UseVisualStyleBackColor = true;
            this.btnRegre.Click += new System.EventHandler(this.btnRegre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de nombres de estudiantes";
            // 
            // FormListAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLista2);
            this.Controls.Add(this.btnLista1);
            this.Name = "FormListAlu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormListAlu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLista1;
        private System.Windows.Forms.Button btnLista2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegre;
        private System.Windows.Forms.Label label1;
    }
}