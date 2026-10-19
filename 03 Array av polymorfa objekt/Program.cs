using _01_Virutell_metod_Djur_och_hunD;
using _02_Polymorfism_och_basklassreferens;

namespace _03_Array_av_polymorfa_objekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Djur[] animals = new Djur[]
            {
                new Djur(),
                new Hund(),
                new Katt(),
            };

            foreach(Djur animal in animals)
            {
                animal.GörLjud();
            }

        }
    }
}
