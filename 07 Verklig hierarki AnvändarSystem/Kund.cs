using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Verklig_hierarki_AnvändarSystem
{
    internal class Kund: Användare
    {
        public override void SkickaHälsningsFras()
        {
            Console.WriteLine("Hej från Klassen ANVÄNDARE!!");
        }
    }
}
