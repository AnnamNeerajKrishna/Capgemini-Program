using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Select_Sums
{

	
	public class prime_RAnge
	{
		public static void Main(string[] args)
		{
			int n, i, p, k, s = 0;
			int a=Convert.ToInt32(Console.ReadLine());	
			n=Convert.ToInt32(Console.ReadLine());	


			

			for (i = a; i <= n; i++)
			{
				k = 2;
				p = 1;
				while (k < i)
				{
					if (i % k == 0)
					{
						p = 0;
						break;
					}
					k++;
				}
				if (p == 1)
				{
					s = s + i;
				}
			}

			Console.WriteLine("Sum of prime numbers:" + s);
			Console.ReadLine();	
		}
	}
}
