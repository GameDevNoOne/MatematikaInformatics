using System;

namespace KvadratniKorenjenec
{
	static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Type the square root you are trying to get");
			long korenjenec = Int64.Parse(Console.ReadLine());
			long? korenjenoStevilo = SquareRoot.KvadratniKoren.Koren(korenjenec);
			if (korenjenoStevilo == null)
			{
				Console.WriteLine("Korenjenec {0} nima celega korena", korenjenec);
				return;
			}
			Console.WriteLine("Koren števila {0} je {1}", korenjenec, korenjenoStevilo);
		}
	}
}

