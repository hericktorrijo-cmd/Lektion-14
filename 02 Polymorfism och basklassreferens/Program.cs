using _01_Virutell_metod_Djur_och_hunD;

namespace _02_Polymorfism_och_basklassreferens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Djur d1 = new Hund();
            d1.GörLjud();
        }
    }
}
