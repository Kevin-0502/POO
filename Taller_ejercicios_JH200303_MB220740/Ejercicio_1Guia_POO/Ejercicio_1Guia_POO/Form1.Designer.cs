namespace Ejercicio_1Guia_POO
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
            this.nudlongitud = new System.Windows.Forms.NumericUpDown();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btngenerarcontraseña = new System.Windows.Forms.Button();
            this.btningreso = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudlongitud)).BeginInit();
            this.SuspendLayout();
            // 
            // nudlongitud
            // 
            this.nudlongitud.Location = new System.Drawing.Point(216, 211);
            this.nudlongitud.Name = "nudlongitud";
            this.nudlongitud.Size = new System.Drawing.Size(110, 22);
            this.nudlongitud.TabIndex = 20;
            this.nudlongitud.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(12, 213);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(175, 17);
            this.lbl3.TabIndex = 19;
            this.lbl3.Text = "Longitud recomendada de 8";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(212, 153);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(377, 22);
            this.txtcontraseña.TabIndex = 18;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(212, 64);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(346, 22);
            this.txtusuario.TabIndex = 17;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(79, 158);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(113, 17);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "CONTRASEÑA";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(79, 64);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 17);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "USUARIO";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.HotPink;
            this.btnlimpiar.Font = new System.Drawing.Font("MS PGothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(460, 350);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(182, 47);
            this.btnlimpiar.TabIndex = 24;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.HotPink;
            this.btnsalir.Font = new System.Drawing.Font("MS PGothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(212, 350);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(182, 47);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btngenerarcontraseña
            // 
            this.btngenerarcontraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btngenerarcontraseña.Font = new System.Drawing.Font("MS PGothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarcontraseña.Location = new System.Drawing.Point(460, 273);
            this.btngenerarcontraseña.Name = "btngenerarcontraseña";
            this.btngenerarcontraseña.Size = new System.Drawing.Size(182, 47);
            this.btngenerarcontraseña.TabIndex = 22;
            this.btngenerarcontraseña.Text = "GENERAR CONTRASEÑA";
            this.btngenerarcontraseña.UseVisualStyleBackColor = false;
            this.btngenerarcontraseña.Click += new System.EventHandler(this.btngenerarcontraseña_Click);
            // 
            // btningreso
            // 
            this.btningreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btningreso.Font = new System.Drawing.Font("MS PGothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningreso.Location = new System.Drawing.Point(212, 273);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(182, 47);
            this.btningreso.TabIndex = 21;
            this.btningreso.Text = "INICIAR SESION";
            this.btningreso.UseVisualStyleBackColor = false;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.Red;
            this.lbl5.Location = new System.Drawing.Point(209, 183);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(492, 17);
            this.lbl5.TabIndex = 25;
            this.lbl5.Text = "AVISO: Añadir a su contraseña al menos 2 mayusculas, 1 minuscula, 5 numeros";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(229, 1);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(338, 45);
            this.lbl4.TabIndex = 26;
            this.lbl4.Text = "INICIO DE SESION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngenerarcontraseña);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.nudlongitud);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudlongitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudlongitud;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngenerarcontraseña;
        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
    }
}

