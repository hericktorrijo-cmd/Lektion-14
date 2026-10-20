namespace _08_Enkel_Try_Catch_Division_med_Noll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ange tal som ska divideras med varandra!");
                Console.Write("Tal 1: ");
                int tal1 = int.Parse(Console.ReadLine());

                Console.Write("Tal 2: ");
                int tal2 = int.Parse(Console.ReadLine());

                int summa = tal1 / tal2;
                Console.WriteLine(summa);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Det går ej att dela med 0!");
            }
            catch(Exception)
            {
                Console.WriteLine("Ett fel uppstod");
            }
            finally
            {
                
                Console.WriteLine("Programmet avslutas");
            }
            
        }
    }
}
