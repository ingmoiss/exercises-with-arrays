using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encontrar valores pares e impares
             int contP=0, contI=0;
             int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };

             foreach(int val in valores)
             {

                 if(val%2 == 0)
                 {
                     contP++;
                 }
                 else
                 {
                     contI++;
                 }
             }

             Console.WriteLine("Hay " + contP + " numeros pares");
             Console.WriteLine("Hay " + contI + " numeros impares");

            Console.WriteLine("---------------------------------------------");
            
            //Encontrar valores de 3 digitos
            int cont = 0;
            int[] valores2 = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };

            foreach(int val in valores2)
            {
                if((val > 100) && (val < 1000))
                {
                    cont++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Hay " + cont + " numeros de 3 cifras");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");

            //Sumar elementos mayores a 15
            int suma = 0;
            int[] numeros = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };

            foreach(int val in numeros)
            {
                if(val > 15)
                {
                    suma += val;
                }
            }

            Console.WriteLine();
            Console.WriteLine("La suma es: " + suma);

            Console.ReadLine();
        }
    }
}
