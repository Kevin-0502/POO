namespace Ejercicio_3Guia_POO
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
            this.btnsaludar = new System.Windows.Forms.Button();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnItaliano = new System.Windows.Forms.Button();
            this.btnJapones = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsaludar
            // 
            this.btnsaludar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnsaludar.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaludar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsaludar.Location = new System.Drawing.Point(92, 83);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(165, 53);
            this.btnsaludar.TabIndex = 0;
            this.btnsaludar.Text = "SALUDAR";
            this.btnsaludar.UseVisualStyleBackColor = false;
            this.btnsaludar.Click += new System.EventHandler(this.btnsaludar_Click);
            // 
            // btnIngles
            // 
            this.btnIngles.BackColor = System.Drawing.Color.Turquoise;
            this.btnIngles.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngles.ForeColor = System.Drawing.Color.Red;
            this.btnIngles.Location = new System.Drawing.Point(104, 171);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(137, 38);
            this.btnIngles.TabIndex = 1;
            this.btnIngles.Text = "INGLES";
            this.btnIngles.UseVisualStyleBackColor = false;
            this.btnIngles.Click += new System.EventHandler(this.btnIngles_Click);
            // 
            // btnItaliano
            // 
            this.btnItaliano.BackColor = System.Drawing.Color.SpringGreen;
            this.btnItaliano.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaliano.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnItaliano.Location = new System.Drawing.Point(104, 245);
            this.btnItaliano.Name = "btnItaliano";
            this.btnItaliano.Size = new System.Drawing.Size(137, 38);
            this.btnItaliano.TabIndex = 2;
            this.btnItaliano.Text = "ITALIANO";
            this.btnItaliano.UseVisualStyleBackColor = false;
            this.btnItaliano.Click += new System.EventHandler(this.btnItaliano_Click);
            // 
            // btnJapones
            // 
            this.btnJapones.BackColor = System.Drawing.Color.Salmon;
            this.btnJapones.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJapones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJapones.Location = new System.Drawing.Point(104, 326);
            this.btnJapones.Name = "btnJapones";
            this.btnJapones.Size = new System.Drawing.Size(137, 38);
            this.btnJapones.TabIndex = 3;
            this.btnJapones.Text = "JAPONES";
            this.btnJapones.UseVisualStyleBackColor = false;
            this.btnJapones.Click += new System.EventHandler(this.btnJapones_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl1.Location = new System.Drawing.Point(90, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(160, 40);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "SALUDOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(354, 395);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnJapones);
            this.Controls.Add(this.btnItaliano);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.btnsaludar);
            this.Name = "Form1";
            this.Text = "Saludos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaludar;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Button btnItaliano;
        private System.Windows.Forms.Button btnJapones;
        private System.Windows.Forms.Label lbl1;
    }
}

