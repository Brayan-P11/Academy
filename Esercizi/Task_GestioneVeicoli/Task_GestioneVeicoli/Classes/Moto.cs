using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_GestioneVeicoli.Classes
{
    internal class Moto : Veicolo
    {
        public Moto() { }

        public override void stampaVeicolo()
        {
            Console.WriteLine($"{Marca} {Cilindrata}");
        }
    }
}
