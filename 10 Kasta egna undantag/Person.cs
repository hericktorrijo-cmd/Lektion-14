using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Kasta_egna_undantag
{
    internal class Person
    {
        private int age;
        public int Age { get { return age; }
           set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Är du Benjamin Button?");
                }
                age = value;
            }
        }

    }
}
