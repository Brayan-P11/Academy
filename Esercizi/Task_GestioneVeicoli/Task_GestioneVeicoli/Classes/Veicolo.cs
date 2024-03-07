using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_GestioneVeicoli.Classes
{
    internal abstract class Veicolo
    {
        public string? Marca { get; set; }

        public int Cilindrata { get; set; }

        public abstract void stampaVeicolo();
    }
}
