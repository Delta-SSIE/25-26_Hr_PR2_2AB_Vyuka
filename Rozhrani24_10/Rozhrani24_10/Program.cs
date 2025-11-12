namespace Rozhrani24_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Auto a = new Auto();
            a.Pohyb();
            IDoprava d = new Auto();
            d.Pohyb();
            a.napisBarvu();
        }
    }
}
