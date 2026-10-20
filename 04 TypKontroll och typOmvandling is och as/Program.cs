using _03_Array_av_polymorfa_objekt;
using _02_Polymorfism_och_basklassreferens;
using _01_Virutell_metod_Djur_och_hunD;



namespace _04_TypKontroll_och_typOmvandling_is_och_as
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

            foreach(Djur d in animals)
            {
                if(d is Hund)
                {
                    Hund hund = d as Hund;
                    hund.ViftaPåSvansen();
                }
            }
            //Så det vi gör här är att vi går igenom hela arrayen av typen Djur för att se om det aktuella objektet i arrayen är av typen Hund, när vi hittar typen Hund så skapar vi en
            //ny referens till samma objekt av Hund som heter hund för att kunna få tillgång till metoden ViftaPåSvansen som ligger i Hund klassen. Detta betyder att
            //d och hund pekar på samma objekt men endast hund har tillgång till metoden eftersom att d fortfarande är av typen djur. Sedan tillkallar vi metoden på hund.

        }
    }
}
