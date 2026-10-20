namespace _09_Fånga_generella_undantag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Skriv ditt favoritnummer");
                Console.Write("Ange talet: ");
                int favoriteNumber = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ditt favoritnummer var {favoriteNumber}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Endast siffror är tillåtna inte bokstäver");
            }
            finally
            {
                Console.WriteLine("Körningen avslutad");
            }
        }
    }
}
