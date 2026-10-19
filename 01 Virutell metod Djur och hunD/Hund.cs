using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Virutell_metod_Djur_och_hunD
{
    public class Hund: Djur
    {
        public override void GörLjud()
        {
            Console.WriteLine("Hunden skäller");
        }
    }
}
