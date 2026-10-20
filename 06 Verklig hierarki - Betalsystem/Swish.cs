using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Verklig_hierarki___Betalsystem
{
    internal class Swish: Betalning
    {
        public override void ProcessaBetalning()
        {
            Console.WriteLine("Klassen SWISH proccesar betalningen....");
        }
    }
}
