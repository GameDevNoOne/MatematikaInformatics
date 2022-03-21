using System;

namespace KvadratniKorenjenec
{
	static class Program
	{
		static void Main(string[] args)
        {
			Console.WriteLine("Type the square root you are trying to get");
			float korenjenec = float.Parse(Console.ReadLine());
            float? korenjenoStevilo = SquareRoot.KvadratniKoren.Koren((float)korenjenec);
			if(korenjenoStevilo == null)
            {
				Console.WriteLine("Korenjenec {0} nima celega korena", korenjenec);
				return;
            }
			Console.WriteLine("Koren števila {0} je {1}",korenjenec, korenjenoStevilo);
        }
	}
}	
