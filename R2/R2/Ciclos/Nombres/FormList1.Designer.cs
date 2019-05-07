namespace R2
{
    partial class FormList1
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
            this.btnDes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.richLista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(77, 226);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(75, 23);
            this.btnDes.TabIndex = 0;
            this.btnDes.Text = "Desplegar";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(179, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // richLista
            // 
            this.richLista.Location = new System.Drawing.Point(12, 12);
            this.richLista.Name = "richLista";
            this.richLista.Size = new System.Drawing.Size(260, 197);
            this.richLista.TabIndex = 2;
            this.richLista.Text = "";
            // 
            // FormList1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.richLista);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDes);
            this.Name = "FormList1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormList1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox richLista;
    }
}