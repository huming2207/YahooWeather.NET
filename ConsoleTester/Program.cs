using System;
using YahooWeatherParser;

namespace ConsoleTester
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var yw = new YahooWeatherControl();
			var result = yw.DoQuery("Melbourne", "Victoria");
			Console.WriteLine(result.Result.Count);
		}
	}
}
