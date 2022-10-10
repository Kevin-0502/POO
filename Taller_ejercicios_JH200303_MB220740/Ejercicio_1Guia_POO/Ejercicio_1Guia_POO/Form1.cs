using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1Guia_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtcontraseña.Text = password.Pass.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Password password = new Password();

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            password.Usuario = txtusuario.Text;
            password.Contraseña = txtcontraseña.Text;
            password.Longitud = int.Parse(nudlongitud.Text);
            


            if (password.esFuerte() == true)
            {
                MessageBox.Show("BIENVENID@ " + password.Usuario + " la contraseña generada es fuerte");
            }
            
            else
            {
                
                MessageBox.Show("" + password.Usuario + " LA CONTRASEÑA PROPORCIONADA ES DEBIL, PRUEBA CON OTRA CONTRASEÑA");
            }
        }

        private void btngenerarcontraseña_Click(object sender, EventArgs e)
        {
            password.Longitud = int.Parse(nudlongitud.Text);
            password.generarPassword(password.Longitud);
            txtcontraseña.Text = password.Contraseña;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
            txtcontraseña.Focus();
        }
    }
}
