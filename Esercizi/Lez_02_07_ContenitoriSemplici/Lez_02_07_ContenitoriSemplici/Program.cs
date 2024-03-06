using System.ComponentModel.DataAnnotations;

namespace Lez_02_07_ContenitoriSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ARRAY
            // possono contenere valori omogenei e sono statici a dimensione fissa

            //int[] numeri = { 6, 67, 23, 15, 2, 6 };
            //numeri[2] = 111; // override
            //Console.WriteLine(numeri[2]);

            //int[] numeri = new int[5];
            //numeri[0] = 6;
            //numeri[1] = 67;
            //numeri[2] = 14;
            //numeri[3] = 5;
            //numeri[4] = 10;

            //int i = 0;
            //while(i < numeri.Length) 
            //{
            //    Console.WriteLine(numeri[i++]);

            //}

            //-----------------
            //string[] parco = { "Maserati", "Lamborghini", "BMW" };
            //for (int i = 0; i < parco.Length; i++) 
            //{
            //    Console.WriteLine(parco[i]);
            //}
            //-----------------

            //string[] parco = { "Maserati", "Lamborghini", "BMW", "FIAT" };
            //string ricerca = "BMW";
            //bool trovato = false;
            //for(int i = 0; i < parco.Length; i++)
            //{
            //    if (parco[i].Equals(ricerca))
            //        trovato = true;
            //}

            //if (trovato)
            //{
            //    Console.WriteLine("Trovato");
            //}
            //else
            //    Console.WriteLine("Non trovato");

            //----------------------

            // FOREACH
            //string[] parco = { "Maserati", "Lamborghini", "BMW", "FIAT" };
            //Array.Sort(parco);
            //foreach(string auto in parco)
            //{
            //    Console.WriteLine(auto);
            //}

            //
            /*
             * Presa una stringa composta in questo modo : "Giovanni, Valeria, Marika, Mario, Valeria".
             * Trasformarla in un array evitando le ripetizioni.
             * 
             * 
             */

            //soluzione personale

            string input = "Giovanni, Valeria, Marika, Mario, Valeria";
            bool diverso = true;
            string[] nomi = new string[5];

            while (diverso)
            {
                nomi[nomi.Length] = input.Split(",");
            }



            // soluzione con StackOverflow
            string input1 = "Giovanni, Valeria, Marika, Mario, Valeria";
            //.Split(",") --> funzione che serve a dividire una stringa in array a partire da un carattere stabilito che in questo caso è la virgola
            //.Distinct() --> paragona e rimuove i duplicati dell'array
            //.ToArray() --> i nomi vengono convertiti in array
            string[] nomi1 = input1.Split(",").Distinct().ToArray();

            foreach (string nome in nomi1)
            {
                Console.WriteLine(nome);

            }

            








        }
    }
}
