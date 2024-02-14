using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:

            // a- 1 si el número es positivo.
            // b- -1 si el número es negativo.
            // c- 0 si el número es cero.
            // Hacer un programa para ingresar 100 números y que nos muestre cuántos son positivos, negativos y ceros.
            int a = 0,conCeros = 0,conPos = 0,conNeg = 0,n;
            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                posNegCero(n,ref a);
                if (a == 0)
                    conCeros ++;
                else if (a == 1)
                    conPos ++;
                else
                    conNeg ++;
            }
            Console.WriteLine("De los 100 números ingresados hay: " + conCeros + " ceros, " + conPos + " positivos y " + conNeg + " negativos.");   
        }
        static void posNegCero(int n1, ref int x){
            if (n1 > 0)
                x = 1;
            else if (n1 == 0)
                x = 0;
            else
                x = -1;
        }
    }
}
                
                
            
            
            
            
