using System;

namespace DecimalConverter
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Napišite decimalni zapis števila");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Napišite število decimalk");
            int decimalke = Int32.Parse(Console.ReadLine());
            Ulomek ulomek = DecimalToUlomek.DecimalnoStevilo(x, decimalke);
            Ulomek novUlomek = ulomek.PokrajsaniUlomek();
            Console.WriteLine("Pokrajšani ulomek je {0}/{1}", novUlomek.Stevec, novUlomek.Imenovalec);
        }
    }
}