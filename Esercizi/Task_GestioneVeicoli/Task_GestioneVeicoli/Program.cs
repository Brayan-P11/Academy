using Task_GestioneVeicoli.Classes;

namespace Task_GestioneVeicoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione veicoli:
             * 
             * All'inserimento di un nuovo veicolo mi sia permessa la scelta tra
             * 1.Automobile
             * 2.Moto
             * 
             * Alla fine dell'inserimento delle caratteristiche del veicolo, stampare i suoi dettagli.
             *
             * Libera scelta degli attributi
             */

            Moto moto1 = new Moto();
            //moto1.Cilindrata = 100;
            //moto1.Marca = "Kawasaki";

            Automobile auto1 = new Automobile();
            //auto1.Cilindrata = 200;
            //auto1.Marca = "Ferrari";

            //auto1.stampaVeicolo();
            //moto1.stampaVeicolo();

            Console.WriteLine("--SCEGLI IL TIPO DI VEICOLO:--");
            Console.WriteLine("1. Automobile");
            Console.WriteLine("2. Moto");


            int scelta = Convert.ToInt32(Console.ReadLine());
            if (scelta == 1)
            {
                Console.WriteLine("Inserisci la marca:");
                auto1.Marca = Console.ReadLine();
                Console.WriteLine("Inserisci la cilindrata:");
                auto1.Cilindrata = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dati inseriti correttamente!");
                auto1.stampaVeicolo();
            } else
            {
                Console.WriteLine("Inserisci la marca:");
                moto1.Marca = Console.ReadLine();
                Console.WriteLine("Inserisci la cilindrata:");
                moto1.Cilindrata = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dati inseriti!");
                Console.WriteLine("Dati inseriti correttamente!");
                moto1.stampaVeicolo();
            }
        }
    }
}
