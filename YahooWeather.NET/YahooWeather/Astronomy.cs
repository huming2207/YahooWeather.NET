using System;
using Newtonsoft.Json;

namespace YahooWeather.NET
{
	[JsonObject()]
	public class Astronomy
	{
		[JsonProperty(PropertyName = "sunrise")]
		public string Sunrise { get; set; }

		[JsonProperty(PropertyName = "sunset")]
		public string Sunset { get; set; }
	}
}

