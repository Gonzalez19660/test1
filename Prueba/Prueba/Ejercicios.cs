﻿using EcuaciónDe2Grado;

namespace Prueba
{
    class Ejercicios
    {
        // Ejercicio: Hacer una función que imprima por pantalla los números del 0 al 99
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador++;
            }
        }

        // Ejercicio: Hacer una función que imprima todos los números pares desde 0 hasta n
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }

        // Ejercicio: Hacer un programa que imprima si un numero es primo o no

        public static void Ejercicio03(int n)
        {
            if (Misc.IsPrime(n))
                System.Console.WriteLine(n + " es un número primo.");
            else
                System.Console.WriteLine(n + " no es número primo");
        }
        
        public static void Ejercicio04(int n)
        {
            // for (int i =0; i < 90; i++)
            // { System.Console.WriteLine(i); }

            int i = 0;
            while (i < 90)
            {
                System.Console.WriteLine(5 - i);
                i++;
            }
        }

        public static void Ejercicio05(int n)
        {
            for (int i = 0; i < 90; i++)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
        }

        public static void Ejercicio06(int n)
        {
            for (int i = 0; i  < 90; i++)
            { 
            int n1 = 0;
            int n2 = 1;
            {
                System.Console.WriteLine(n1);
                System.Console.WriteLine(n2);
                System.Console.WriteLine(n1 + n2);    
                System.Console.WriteLine(n2 = n1 + n2);
                System.Console.WriteLine(n1 = n2 - n1);
                }
            }
        }
    }
}
