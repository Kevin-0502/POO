using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprod1_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD1");
        }

        private void btnprod2_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD2");
        }

        private void btnprod3_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD3");
        }

        private void btnprod4_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD4");
        }

        private void btnprod5_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD5");
        }

        private void btnprod6_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD6");
        }

        private void btnprod7_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD7");
        }

        private void btnprod8_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD8");
        }

        private void btnprod9_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD9");
        }

        private void btnprod10_Click(object sender, EventArgs e)
        {
            carrito.Items.Add("PROD10");
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            double suma = 0;
            for (int i = 0; i < carrito.Items.Count; i++)
            {
                suma += getPrecio(carrito.Items[i].ToString());
            }

            string date = DateTime.Now.ToString();
            lblresponse.Text = "Fecha de facturación: "+date+"\nTotal a pagar = $" + (suma*1.2);
            MessageBox.Show("Total = $" + (suma*1.2));

        }
       
        private void btnclear_Click(object sender, EventArgs e)
        {
            carrito.Items.Clear();
            lblresponse.Text = "l";
        }

        private double getPrecio(string id)
        {
            double precio = 0;
            switch (id)
            {
                case "PROD1":
                    precio = 10.0;
                    break;
                case "PROD2":
                    precio = 20.0;
                    break;
                case "PROD3":
                    precio = 30.0;
                    break;
                case "PROD4":
                    precio = 40.0;
                    break;
                case "PROD5":
                    precio = 50.0;
                    break;
                case "PROD6":
                    precio = 60.0;
                    break;
                case "PROD7":
                    precio = 70.0;
                    break;
                case "PROD8":
                    precio = 80.0;
                    break;
                case "PROD9":
                    precio = 90.0;
                    break;
                case "PROD10":
                    precio = 100.0;
                    break;
                default:
                    precio = 0.0;
                    break;
            }
            return precio;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
