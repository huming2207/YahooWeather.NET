using System;
using Newtonsoft.Json;

namespace YahooWeatherParser.Shared
{
	[JsonObject()]
	public class Wind
	{
		[JsonProperty(PropertyName = "chill")]
		public int Chill { get; set; }

		[JsonProperty(PropertyName = "direction")]
		public int Direction { get; set; }

		[JsonProperty(PropertyName = "speed")]
		public double Speed { get; set; }
	}
}

