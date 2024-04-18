﻿namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Snack 1
            // - void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.
            Console.WriteLine(Prettifier("Snack 1"));
            StampaArray(new int[] { 1, 2, 3, 4, 5 });
            void StampaArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("]");
            }

            Console.WriteLine();

            // Snack 2
            // - int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
            Console.WriteLine(Prettifier("Snack 2"));
            Console.WriteLine(Quadrato(5));
            int Quadrato(int numero)
            {
                return numero * numero;
            }
        }

        private static string Prettifier(string input)
        {
            string output = $"{String.Concat(Enumerable.Repeat("-", input.Length + 2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length + 2))}";
            return output;
        }
    }
}
