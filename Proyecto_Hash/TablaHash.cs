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

            if (arregloLista[indice] == null)
            {
                arregloLista[indice] = new ListaLigada(charString);
                return;
            }

            arregloLista[indice].Agregar(charString);
        }

        public void Print()
        {
            int indice = 0;
            foreach (ListaLigada lista in arregloLista)
            {
                string valoresLista = "";

                if (lista != null)
                {
                    valoresLista = lista.ObtenerLista();
                }
                
                Console.WriteLine(indice + ": " + valoresLista);
                indice++;
            }
        }
    }
}
