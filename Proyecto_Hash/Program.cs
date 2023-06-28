using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] palabras = new string[3];
            //ListaLigada[] tablaHash = new ListaLigada[5];
            TablaHash hash = new TablaHash(5);

            hash.Add("Hol@");
            Console.ReadKey();
            /*palabras[0] = "Hol";
            palabras[2] = "Adi";

            Console.WriteLine(palabras[0]);
            */
        }
    }
}
