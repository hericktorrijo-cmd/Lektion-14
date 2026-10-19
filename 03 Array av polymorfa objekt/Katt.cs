using System;
using System.Collections.Generic;
using System.Text;
using _01_Virutell_metod_Djur_och_hunD;

namespace _03_Array_av_polymorfa_objekt
{
    public class Katt: Djur
    {
        public override void GörLjud()
        {
            Console.WriteLine("Katten gör ljud....");
        }
    }
}
