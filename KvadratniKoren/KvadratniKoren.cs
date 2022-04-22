using System;

namespace SquareRoot
{
    public class KvadratniKoren
    {
        //Koren - Število, ki ga korenim
        //a - Število, ki je koren
        public static long? Koren(long korenjenec)
        {
            long a = 1;
            long b = korenjenec / a;
            while (true)
            {

                long c = (a + b) / 2;
                long kvadrat = c * c;
                long razlika = b - a;
                if (kvadrat == korenjenec)
                {
                    return (long?)c;
                }
                if (kvadrat > korenjenec)
                {
                    b = c;
                }
                if (kvadrat < korenjenec)
                {
                    a = c;
                }
                if (razlika <= 1)
                {
                    return null;
                }

            }
        }
    }
}
