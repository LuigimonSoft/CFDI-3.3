namespace ProbadorCFDI33
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCFDI = new System.Windows.Forms.Button();
            this.txtXML = new ScintillaNET.Scintilla();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCFDI
            // 
            this.btnCFDI.Location = new System.Drawing.Point(493, 12);
            this.btnCFDI.Name = "btnCFDI";
            this.btnCFDI.Size = new System.Drawing.Size(75, 23);
            this.btnCFDI.TabIndex = 0;
            this.btnCFDI.Text = "Gen CFDI";
            this.btnCFDI.UseVisualStyleBackColor = true;
            this.btnCFDI.Click += new System.EventHandler(this.btnCFDI_Click);
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(12, 41);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(556, 397);
            this.txtXML.TabIndex = 1;
            this.txtXML.Text = "scintilla1";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(493, 444);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar xml";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 488);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.btnCFDI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCFDI;
        private ScintillaNET.Scintilla txtXML;
        private System.Windows.Forms.Button btnCargar;
    }
}

