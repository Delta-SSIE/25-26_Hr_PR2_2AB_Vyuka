namespace Rozhrani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil m = new Mobil();
            Notebook n = new Notebook();
            m.Zapnout();
            n.Zapnout();
            m.Vypnout();
            n.Vypnout();
        }
    }
}
