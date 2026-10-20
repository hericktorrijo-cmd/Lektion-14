using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Verklig_hierarki_AnvändarSystem
{
    internal class Admin: Användare
    {

        public override void SkickaHälsningsFras()
        {
            Console.WriteLine("Hej från klassen ADMIN!!!!!!!!!!!!");
        }
        public void NollställSystem()
        {
            Console.WriteLine("Klassen ADMIN RENSAR SYSTEM!!");
        }
    }
}
