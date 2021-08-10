using System;
using System.Globalization;

namespace Uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;
                        
            double area_triang_retangulo = (A * C)/2;
            double area_circulo = pi * Math.Pow(C, 2.0);
            double area_trapezio = ((A + B) / 2) * C;
            double area_quadrado = Math.Pow(B, 2);
            double area_retangulo = A * B;
            
            Console.WriteLine($"TRIANGULO: {area_triang_retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {area_circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {area_trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {area_quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {area_retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

                                 
        }
    }
}
