using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    public class Persoon
    {
        public string Naam { get; set; }

        public Persoon(string naam)
        {
            Naam = naam;
        }

        public string getNaam() { 
            return this.Naam;
        }

        public override string ToString() // Zo kan ik de data van Persoon printen, anders krijg ik Opdracht3.Persoon te zien in plaats van de naam
        {
            return "Persoon - Naam: " + Naam;
        }
    }



}
