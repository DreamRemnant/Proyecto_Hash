using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Hash
{
    internal class TablaHash
    {
        private ListaLigada[] arregloLista;

        public TablaHash(int size)
        {
            arregloLista = new ListaLigada[size];
        }

        public void Add(string charString)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(charString);
            int suma = 0;
            foreach (byte b in bytes)
            {
                suma += b;
            }
            int indice = suma % arregloLista.Length;
            arregloLista[indice].Agregar(charString);
        }

        public void Print()
        {
            foreach (ListaLigada lista in arregloLista)
            {
                int indice = 0;
                Console.WriteLine(indice + ":" + lista.ObtenerLista());
            }
        }
    }
}
