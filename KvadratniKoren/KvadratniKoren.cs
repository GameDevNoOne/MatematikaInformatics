using System;

namespace SquareRoot
{
    public class KvadratniKoren
    {
        //Koren - Število, ki ga korenim
        //a - Število, ki je koren
        public static float? Koren(float korenjenec)
        {
            float a = 1;
            float b = korenjenec / a;
            while (true)
            {

                float c = (a + b) / 2;
                float kvadrat = c * c;
                if (kvadrat == korenjenec)
                {
                    return (long?)c;
                }
                if(kvadrat > korenjenec)
                {
                    b = c;
                }
                if(kvadrat < korenjenec)
                {
                    a = c;
                }
                if(b - a <= 0.001)
                {
                    return null;
                }
                
            }
        }
    }
}
