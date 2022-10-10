using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3Guia_POO
{
    public partial class Form1 : Form
    {

        private Idiomas Lenguaje;

        public Form1()
        {
            InitializeComponent();
            Lenguaje = new Ingles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Lenguaje.Saludar());
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            Lenguaje = new Ingles();
        }

        private void btnItaliano_Click(object sender, EventArgs e)
        {
            Lenguaje = new Italiano();
        }

        private void btnJapones_Click(object sender, EventArgs e)
        {
            Lenguaje = new Japones();
        }
    }
}
