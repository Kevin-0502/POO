namespace WindowsFormsApp1
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
            this.lblISBN = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblautor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txtnpaginas = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(47, 23);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(97, 39);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(47, 77);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(102, 39);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Titulo";
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautor.Location = new System.Drawing.Point(47, 131);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(100, 39);
            this.lblautor.TabIndex = 2;
            this.lblautor.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de paginas";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(171, 41);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(345, 20);
            this.txtisbn.TabIndex = 4;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(171, 95);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(345, 20);
            this.txttitulo.TabIndex = 5;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(171, 150);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(345, 20);
            this.txtautor.TabIndex = 6;
            // 
            // txtnpaginas
            // 
            this.txtnpaginas.Location = new System.Drawing.Point(385, 207);
            this.txtnpaginas.Name = "txtnpaginas";
            this.txtnpaginas.Size = new System.Drawing.Size(131, 20);
            this.txtnpaginas.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(399, 253);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(117, 39);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(248, 253);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(117, 39);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 314);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnpaginas);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblautor);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblISBN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblautor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txtnpaginas;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
    }
}

