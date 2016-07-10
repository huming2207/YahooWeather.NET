using System;
using YahooWeatherParser;

namespace ConsoleTester
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// In the real situation, you should use async/await instead. 
			// Here I use async method as sync just for convenience. :)
			Console.WriteLine("Hello World!");
			var yw = new YahooWeatherControl();
			var result = yw.DoQuery("Melbourne", "Victoria");


			Console.WriteLine("Query Count: {0}", result.Result.Count);
			Console.WriteLine("Current temperature in Melbourne: {0}", result.Result.Results.Channel.Item.Condition.Temperature);
			Console.WriteLine("Weather status in Melbourne right now: {0}", result.Result.Results.Channel.Item.Condition.StatusText);
			Console.WriteLine("Highest temperature in Melbourne tomorrow: {0}", result.Result.Results.Channel.Item.Forecast[0].High);
			Console.WriteLine("Lowest temperature in Melbourne tomorrow: {0}", result.Result.Results.Channel.Item.Forecast[0].Low);
		}
	}
}
