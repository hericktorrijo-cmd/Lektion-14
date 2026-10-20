namespace _13_StartSammanhållning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMeddelandeTjänst tjänst = new EpostTjänst();
            //Notifierare n1 = new Notifierare(tjänst);

            IMeddelandeTjänst tjänst = new SmsTjänst();

            Notifierare notifierare = new Notifierare(tjänst);

            //Notifierare arbetar mot interfacet IMeddelandeTjänst istället för en specifik klass. 
            //Därför kan EpostTjänst enkelt bytas ut mot SmsTjänst utan att någon kod behöver ändras i Notifierare-klassen. Detta gör programmet flexibelt och är ett exempel på lös koppling.

        }
    }
}
