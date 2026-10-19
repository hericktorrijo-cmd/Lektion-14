namespace _01_Virutell_metod_Djur_och_hunD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund();
            Djur d1 = new Djur();
            d1.GörLjud();
            h1.GörLjud();
        }
    }
}
