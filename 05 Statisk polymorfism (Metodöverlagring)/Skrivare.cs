using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Statisk_polymorfism__Metodöverlagring_
{
    internal class Skrivare
    {
        public void SkrivUt(string name)
        {
            Console.WriteLine("Du har en metod med parameter av typen string");
        }

        public void SkrivUt(int nummber)
        {
            Console.WriteLine("Du har en metod med parameter av typen INT");
        }
    }
}
