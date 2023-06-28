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
            TablaHash hashTable = new TablaHash(5);

            Console.WriteLine("=========TABLA HASH=========");

            hashTable.Add("Hol@");
            hashTable.Add("<peroC0moEsP0s1ble>");
            hashTable.Add("percebes .__.");
            hashTable.Add("Juan Martinez");
            hashTable.Add("QueTieneDeBuenoLaTontaTexas");
            hashTable.Add("Esp3r0 que este b13n :')");
            hashTable.Add("prueba2");
            hashTable.Add("prueba4");

            hashTable.Print();
            Console.ReadLine();
        }
    }
}
