using System;
using System.Collections.Generic;
using System.Text;

namespace _13_StartSammanhållning
{
    internal class SmsTjänst : IMeddelandeTjänst
    {
        public void Skicka(string text)
        {
            Console.WriteLine(text);
        }
    }
}
