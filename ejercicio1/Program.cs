using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            float precioArt,monto;
            int cantVendida;
            Console.WriteLine("Ingrese el precio del artículo:");
            precioArt = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantVendida = int.Parse(Console.ReadLine());
            monto = producto(precioArt,cantVendida);
            Console.WriteLine("El monto total a pagar es de: " + monto);
        }
        static float producto(float a, int b){
            // float r;
            // r = a * b; -----> y return r
            return a * b;
            // recordar que para que el resultado sea float nos basta con poner una de las 2 variables que operan en float
        }
    }
}
