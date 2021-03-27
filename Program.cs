using System;

namespace A133590.Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 18");
            Console.WriteLine("Dado un número, lo redondea a 2 decimales.");
            Console.Write("Por favor, ingrese un número: ");
            double numero;
            bool exito = Double.TryParse(Console.ReadLine(), out numero);
            if (!exito)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }

            Console.WriteLine($"Número redondeado a dos decimales: {Math.Round(numero,2)}");

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();


        }
    }
}
