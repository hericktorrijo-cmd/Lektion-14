namespace _06_Verklig_hierarki___Betalsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Betalning b1 = new Betalning();
            Kreditkort k1 = new Kreditkort();
            Swish s1 = new Swish();

            b1.ProcessaBetalning();
            k1.ProcessaBetalning();
            s1.ProcessaBetalning();
        }
    }
}
