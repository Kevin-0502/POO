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
    public partial class Form2 : Form
    {
        public List<Cliente> clienteListRecibe = null;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            bool logueado = false;
            foreach (var user in clienteListRecibe)
            {
                if (user.Name == txtuser.Text.ToString() && user.Password == txtpass.Text.ToString())
                {
                    logueado=true;
                }
            }
            if (logueado)
            {
                this.Hide();
                form1.Show();
            }
            else { MessageBox.Show("Datos erroneos"); }
        }

       

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Close();
            form3.Show();
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
