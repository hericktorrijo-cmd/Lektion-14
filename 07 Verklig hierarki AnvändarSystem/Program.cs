namespace _07_Verklig_hierarki_AnvändarSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Användare> användare = new List<Användare>();
            användare.Add(new Användare());
            användare.Add(new Kund());
            användare.Add(new Admin());
            int antalAdmin = 0;

            

            foreach(Användare s in användare)
            {
                
                if (s is Admin)
                {
                    
                    Admin admin = s as Admin;
                    admin.NollställSystem();
                    antalAdmin++; 
                }           

            }
            Console.WriteLine($"Vi hittade totalt {antalAdmin} st Admin i Listan!");

        }
    }
}
