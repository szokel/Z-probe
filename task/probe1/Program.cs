using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static async Task Main()
		{
			Console.WriteLine("Hello Task World!");
			var i = await sum();  // itt létre fog jönni egy uj szál, mert async a doit.
			Console.WriteLine($"program is done, i is {i}");
		}

		static async Task<int> sum()
		{
			var res = await res3();
			return res;
		}

		static Task<int> res3()
		{
			var t = new Task<int>(() => 3);
			t.Start();
			return t;
		}

	}
}
