using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n,con = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if (par(n) == 1)
                {
                    con ++;
                }
            }
                Console.WriteLine("De los 20 números ingresados, " + con + " son pares.");
        }
        static int par(int num){
            if (num % 2 == 0)
            {
                return 1;
            }else
            {
                return 0;
            }
        }
    }
}
