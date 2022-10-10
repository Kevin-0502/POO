using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Libro nuevoLibro= new Libro();

        private void btnguardar_Click(object sender, EventArgs e)
        {
            nuevoLibro.ISBN = txtisbn.Text;
            nuevoLibro.Titulo = txttitulo.Text;
            nuevoLibro.Autor = txtautor.Text;
            nuevoLibro.Npaginas = txtnpaginas.Text;
            MessageBox.Show(nuevoLibro.ToString());
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtisbn.Clear();
            txttitulo.Clear();
            txtautor.Clear();
            txtnpaginas.Clear();
        }
    }
}
