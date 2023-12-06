using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            float A= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float B = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceito número: ");
            float C = float.Parse(Console.ReadLine());

            // Área do triangulo 

            float atrig = (A * C) / 2;
            Console.WriteLine("Área do triangulo é: "+ atrig);

            // Área do circulo

            double acirc = 3.14159 * (C * C);
            Console.WriteLine("Área do circulo é: "+ acirc);

            // Área do trapézio 

            float atrap = (A + B)* C/2;
            Console.WriteLine("Área do trapézio é: " + atrap);


            // Área do quadrado 
            float aquad = B * B;
            Console.WriteLine("Área do quadrado é: " + aquad);


            // Área do retangulo
            float aret = A * B;
            Console.WriteLine("Área do retangulo é: " + aret);
        }
    }
}
