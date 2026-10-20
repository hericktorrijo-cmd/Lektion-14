using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Verklig_hierarki___Betalsystem
{
    internal class Betalning
    {
        public int Belopp {  get; set; }

        public virtual void ProcessaBetalning()
        {
            Console.WriteLine("Klassen betalning proccesar betalningen....");
        }
    }
}
