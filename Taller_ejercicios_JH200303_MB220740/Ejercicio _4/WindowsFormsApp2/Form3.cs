using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private List<Cliente> clienteList = new List<Cliente>();
        public Form3()
        {
            InitializeComponent();
            Cliente add_cliente = new Cliente();
            add_cliente.Name = "Kevin";
            add_cliente.Mail = "kevin@gmail.com";
            add_cliente.Mail2 = "miguel@gmail.com";
            add_cliente.Age = 20;
            add_cliente.Password = "Ilus10$$";
            clienteList.Add(add_cliente);
            Cliente add_cliente2 = new Cliente();
            add_cliente2.Name = "María";
            add_cliente2.Mail = "linda@gmail.com";
            add_cliente2.Mail2 = "maria@gmail.com";
            add_cliente2.Age = 21;
            add_cliente2.Password = "Cola123$";
            clienteList.Add(add_cliente);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.clienteListRecibe = clienteList;
            form2.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validaciones(txtname.Text, txtmail.Text, txtmail2.Text, int.Parse(txtage.Text), txtpass.Text))
            {
                Cliente add_cliente3 = new Cliente();
                add_cliente3.Name = txtname.Text;
                add_cliente3.Mail = txtmail.Text;
                add_cliente3.Mail2 = txtmail2.Text;
                add_cliente3.Age = int.Parse(txtage.Text);
                add_cliente3.Password = txtpass.Text;
                clienteList.Add(add_cliente3);
                MessageBox.Show("Usuario guardado correctamente");
                Form2 form2 = new Form2();
                form2.clienteListRecibe = clienteList;
                form2.Show();
                this.Hide();
            }else { MessageBox.Show("Alguna validacion fallo, revise bien los datos"); }
            
        }

        //validaciones
        private bool validaciones(string name, string mail, string mail2,int age, string password)
        {
            bool todo_ok = false;
            bool name_ok=false,mails_ok=false,age_ok = false, password_ok=false;
            //validación de correo    
            Regex regex_mail = new Regex("[@gmail.com]+");
            if (regex_mail.IsMatch(mail) && regex_mail.IsMatch(mail2))
            {
                mails_ok = true;
            }
            else { MessageBox.Show("Correo no valido!"); }
            //validacion de edad
            if (age >= 18)
            {
                age_ok = true;
            }
            else { MessageBox.Show("Debe ser mayor de Edad"); }
            if(age_ok&&mails_ok)
            {
                todo_ok = true;
            }

            return todo_ok;
        }
    }
}
