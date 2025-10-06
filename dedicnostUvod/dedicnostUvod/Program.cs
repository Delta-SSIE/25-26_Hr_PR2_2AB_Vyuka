namespace dedicnostUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Student s = new Student();
            s.Jmeno = "Karel";
            s.Pozdrav();
            s.UciSe();
           Console.WriteLine( s.ToString());
            Ucitel u = new Ucitel();
            u.Jmeno = "Veronika";
            u.Pozdrav();
            u.OpravujuTest();
            Console.WriteLine(u.ToString());
            Osoba o = new Osoba();
            o.Jmeno = "nekdo";
            o.Pozdrav();
            Console.WriteLine(o.ToString());
        }
    }
}
