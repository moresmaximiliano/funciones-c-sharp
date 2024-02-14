using System;

namespace ejercicio2plus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n,con = 0;
            bool indice;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if(indice = par(n))
                {
                    con ++;
                }
            }
                Console.WriteLine("De los 20 números ingresados, " + con + " son pares.");
        }
        static bool par(int num){
            if (num % 2 == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
