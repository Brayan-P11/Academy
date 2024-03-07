using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_GestioneVeicoli.Classes
{
    internal class Automobile : Veicolo
    {
        public Automobile() { }

        public override void stampaVeicolo()
        {
            Console.WriteLine($"{Marca} {Cilindrata}");
        }
    }
}
