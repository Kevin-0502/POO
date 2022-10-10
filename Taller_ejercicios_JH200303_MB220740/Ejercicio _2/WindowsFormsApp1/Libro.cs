using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Libro
    {
        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private string npaginas;
        public string Npaginas
        {
            get { return npaginas; }
            set { npaginas = value; }
        }

        override public string ToString()
        {
            return "El libro con "+isbn+" creado por "+autor+" tiene "+npaginas+" paginas";
        }

    }
}
