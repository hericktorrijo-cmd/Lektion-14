using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Virutell_metod_Djur_och_hunD
{
    public class Djur
    {

        public virtual void GörLjud()
        {
            Console.WriteLine("Djuret gör ljud...");
        }
    }
}
