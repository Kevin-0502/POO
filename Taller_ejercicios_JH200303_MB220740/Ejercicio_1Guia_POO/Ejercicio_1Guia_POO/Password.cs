using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1Guia_POO
{
    internal class Password
    {
        //ATRIBUTOS
        int longitud = 8;
        string contraseña;
        string usuario;
        int pass = (12345678);


        //PROPIEDADES
        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public int Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }

        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }



        public Password()
        {
            int cadena;
            cadena = (12345678);

        }

        //METODOS
        public void generarPassword(int longitud)
        {
            // Declaramos array que contendrá todas las letras
            char[] arrayLetras = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Declaramos array que contendrá los números
            int[] arrayNumeros = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Generando un objeto random
            Random random = new Random();

            // Variables que contarán los números y letras colocados en el password
            int cantNumeros = 0, cantMinusculas = 0, cantMayusculas = 0;

            // Variable que almacenará el password
            string password = "";

            // bucle que irá agregando cada letra y número a la contraseña 
            for (int i = 0; i <= longitud; i++)
            {
                // Agregando 3 letras mayúsculas aleatorias al password
                if (cantMayusculas <= 1)
                {
                    int numeroRandom = random.Next(0, 25); // Generará un número aleatorio entre 0 y 25, ese número será la letrá que se tomará del arrayLetras
                    char Letra = arrayLetras[numeroRandom];

                    // Agregando la letra resultante al password
                    password += char.ToUpper(Letra); // char.ToUpper vuelve mayúscula la letra

                    cantMayusculas++;
                }
                // Agregando 1 letra minúscula aleatoria al password
                else if (cantMinusculas < 1)
                {
                    int numeroRandom = random.Next(0, 25); // Generará un número aleatorio entre 0 y 25, ese número será la letrá que se tomará del arrayLetras
                    char Letra = arrayLetras[numeroRandom];

                    // Agregando la letra resultante al password
                    password += Letra;

                    cantMinusculas++;
                }
                // Agregando números para completar la longitud del password
                else
                {
                    int numeroRandom = random.Next(0, 9); // Generará un número aleatorio entre 0 y 25, ese número será la letrá que se tomará del arrayLetras
                    int numero = arrayNumeros[numeroRandom];

                    // Agregando la letra resultante al password
                    password += numero.ToString();

                    cantNumeros++;
                }
            }

            contraseña = password;
        }

        public Boolean esFuerte()
        {
            int cuentanumeros = 0, mayus = 0, min = 0;
            for (int i = 0; i < contraseña.Length; i++)
            {
                cuentanumeros += 1;
              
            }
            if (cuentanumeros >= 8)
            {
                return true;
            }
            else if (mayus >= 2)
            {
                return true;
            }
            else if (min >= 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
