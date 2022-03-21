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
                if (kvadrat == korenjenec)
                {
                    return c;
                }
                if(kvadrat > korenjenec)
                {
                    b = c;
                }
                if(kvadrat < korenjenec)
                {
                    a = c;
                }
                if(b - a <= 1)
                {
                    return null;
                }
                
            }
        }
    }
}
