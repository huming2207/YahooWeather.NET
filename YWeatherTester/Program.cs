using System;
using System.Threading.Tasks;
using YahooWeather;
using YahooWeather.NET;

namespace YWeatherTester
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			getTask().Wait();
		}

		public static async Task getTask()
		{
			YahooWeatherControl yw = new YahooWeatherControl();
			Query query = await yw.DoQuery("Melbourne", "Victoria");
			Console.WriteLine("Temperature: " + query.Results.Channel.Item.Condition.Temperature);
		}
	}
}
