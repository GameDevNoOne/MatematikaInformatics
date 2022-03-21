using System;
using Matematika;

namespace DecimalConverter
{
    public static
     class DecimalToUlomek
    {
        public static Ulomek DecimalnoStevilo(double x, int decimalke)
        {
            int potenca = 10.Power(decimalke);
            int imenovalec = potenca - 1;
            int stevec = (int)Math.Round((potenca * x) - x);
            Ulomek ulomek = new Ulomek(stevec, imenovalec);
            return ulomek.PokrajsaniUlomek();
        }
    }
}