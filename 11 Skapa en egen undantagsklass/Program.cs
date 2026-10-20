namespace _11_Skapa_en_egen_undantagsklass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bankkonto b1 = new Bankkonto();
                b1.Uttag(5);
                Console.WriteLine(b1.Saldo);

                b1.Uttag(50);
                Console.WriteLine(b1.Saldo);
            }
            catch(SaldoSaknasException temporärVariabel)
            {
                Console.WriteLine(temporärVariabel.Message);
            }
        }
    }
}
