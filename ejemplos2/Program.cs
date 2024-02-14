using System;
using System.Globalization;

namespace ejemplos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0,n2 = 0,resultado;
            pedirDatos(ref n1,ref n2);
            resultado = sumar(n1,n2);
            Console.WriteLine("El resultado de su suma es: " + resultado);
            // Console.WriteLine(n1);
        }

        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
            // si pongo a = 9999; 
            // nos va a seguir mostrando el valor original del argumento n1, ya que pasamos el parámetro por valor, no permitiéndonos alterar su contenido (copias prestadas de n1 y n2).
            // en vez si pongo (ref n1) en la Main y (ref int a) en Sumar, si cambia el valor original, ya que al pasar por referencia nos permite modificar el mismo.
        }

        static void pedirDatos(ref int j,ref int h){
            Console.WriteLine("Ingrese un nro:");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un nro:");
            h = int.Parse(Console.ReadLine());
        }
    }
}
