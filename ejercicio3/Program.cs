using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int n,con = 0;
            float promedioPrimos,acu=0;
            // Acordarse que para que el promedio me pueda dar float solo basta con poner uno de sus componentes de la división tambien en float para que me de.
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (primo(n))
                {
                    acu += n;
                    con ++;
                }
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }
            promedioPrimos = acu / con;
            Console.WriteLine("El promedio de los números primos ingesados es igual a " + promedioPrimos);
        }
        static bool primo(int n1){
            int constante = 0;
            for (int x = 1; x <= n1; x++)
            {
                if (n1 % x == 0)
                {
                    constante ++;
                }
            }
            if (constante == 2)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
