using System;
using System.Collections.Generic;

class MainClass
{
	public static void Main(string[] args)
	{
		HashSet<int> NoPe = new HashSet<int>();
		long licznik = 0;
		int n = 0;
		n = int.Parse(Console.ReadLine());
		for (int x = 2; x < n; x++)
		{
			for (int y = x * 2; y < n; y = y + x)
			{
				if (!NoPe.Contains(y))
				{
					NoPe.Add(y);
				}
			}

			for (int z = 2; z < n; z++)
			{
				if (!NoPe.Contains(z))
				{
					Console.WriteLine(z);
					licznik = licznik + z;
				}
			}

			Console.WriteLine("Sum is: " + licznik);
		}
	}
}