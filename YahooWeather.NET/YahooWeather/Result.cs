using System;
using Newtonsoft.Json;

namespace YahooWeather.NET
{
	[JsonObject()]
	public class Results
	{
		[JsonProperty(PropertyName = "channel")]
		public Channel Channel { get; set; }
	}
}

