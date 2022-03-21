using System;
using EuclidsAlgorithm;

namespace DecimalConverter
{
    public class Ulomek
    {
        public Ulomek(int stevec, int imenovalec)
        {
            this.Stevec = stevec;
            this.Imenovalec = imenovalec;
        }
        public int Stevec { get; }
        public int Imenovalec { get; }
        public Ulomek PokrajsaniUlomek()
        {
            int okrajsava = EuclidsAlgorithm.EvklidovAlgoritem.NSD(Stevec, Imenovalec);
            return new Ulomek(Stevec / okrajsava, Imenovalec / okrajsava);
        }
    }
}