using System;

namespace YahooWeatherParser
{
	public class YahooWeatherException : Exception
	{
		public YahooWeatherException()
		{
			// Leave it empty
		}

		public YahooWeatherException(string message, Exception inner) : base(message, inner)
		{
			// Leave it empty
		}

		public YahooWeatherException(string message) : base(message)
		{
			// Leave it empty
		}

		public string Json { get; set; }
	}
}

