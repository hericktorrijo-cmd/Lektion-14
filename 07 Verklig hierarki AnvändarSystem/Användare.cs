using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Verklig_hierarki_AnvändarSystem
{
    internal class Användare
    {
        

        public virtual void SkickaHälsningsFras()
        {
            Console.WriteLine("Hej från klassen: ANVÄNDARE");
        }
    }
}
