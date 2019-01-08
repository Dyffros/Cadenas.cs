using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string PrimerAmigo = "María";
            string SegundoAmigo = "Sergio";
            Console.WriteLine($"Mis amigos son {PrimerAmigo} y {SegundoAmigo}");

            Console.WriteLine($"El nombre de {PrimerAmigo} tiene {PrimerAmigo.Length} letras");
            Console.WriteLine($"El nombre de {SegundoAmigo} tiene {SegundoAmigo.Length} letras");
            Console.ReadLine();
        }
    }
}
