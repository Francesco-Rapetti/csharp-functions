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
                Console.WriteLine($"[{String.Join(", ", array)}]");
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

            Console.WriteLine();

            // Snack 3
            // - int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. 
            // ATTENZIONE: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
            Console.WriteLine(Prettifier("Snack 3"));
            StampaArray(ElevaArrayAlQuadrato(new int[] { 1, 2, 3, 4, 5 }));
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                return array.Select(x => Quadrato(x)).ToArray();
            }

            Console.WriteLine();

            // Snack 4
            // - int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
            Console.WriteLine(Prettifier("Snack 4"));
            Console.WriteLine(sommaElementiArray(new int[] { 1, 2, 3, 4, 5 }));
            int sommaElementiArray(int[] array)
            {
                return array.Sum();
            }

            Console.WriteLine();

            // Snack 5
            /*
                Una volta completate queste funzioni di utilità di base, 
                e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, 
                si vogliono utilizzare le funzioni per:
                - Stampare l’array di numeri fornito a video
                - Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato 
                    (Verificare che l’array originale non sia stato modificato quindi ristampare 
                    nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
                - Stampare la somma di tutti i numeri
                - Stampare la somma di tutti i numeri elevati al quadrato
            */
            Console.WriteLine(Prettifier("Snack 5"));
            int[] array = { 2, 6, 7, 5, 3, 9 };
            StampaArray(array);
            StampaArray(ElevaArrayAlQuadrato(array));
            StampaArray(array);
            Console.WriteLine(sommaElementiArray(array));
            Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(array)));

            Console.WriteLine();

            // BONUS
            /* 
                Convertire le funzioni appena dichiarate in funzioni generiche, 
                ossia funzioni che possono lavorare con array di numeri interi **di lunghezza variabile**, 
                ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
                A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, 
                e dopo di che questi vengono inseriti a mano dall’utente esternamente. 
                Rieseguire il programma con l’input preso esternamente dall’utente.
            */
            Console.WriteLine(Prettifier("BONUS"));
            bool control = true;
            Console.WriteLine("Inserisci quanti numeri vuoi");
            int arrayLength = 0;
            while (control)
            {
                try
                {
                    arrayLength = Convert.ToInt32(Console.ReadLine());
                    control = false;
                } catch (FormatException)
                {
                    Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                    control = true;
                }
            }
            control = true;
            int[] userArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                while (control)
                {
                    try
                    {
                        Console.WriteLine($"Inserisci il {i + 1}° numero");
                        userArray[i] = Convert.ToInt32(Console.ReadLine());
                        control = false;

                    } catch (FormatException)
                    {
                        Console.WriteLine("ERRORE: Il valore inserito non è un numero");
                        control = true;
                    }
                }
                control = true;
            }
            Console.WriteLine();
            StampaArray(userArray);
            StampaArray(ElevaArrayAlQuadrato(userArray));
            StampaArray(userArray);
            Console.WriteLine(sommaElementiArray(userArray));
            Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(userArray)));
        }

        private static string Prettifier(string input)
        {
            string output = $"{String.Concat(Enumerable.Repeat("-", input.Length + 2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length + 2))}";
            return output;
        }
    }
}
