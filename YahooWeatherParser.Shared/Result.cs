using System;
using Newtonsoft.Json;

namespace YahooWeatherParser.Shared
{
	[JsonObject()]
	public class Results
	{
		[JsonProperty(PropertyName = "channel")]
		public Channel Channel { get; set; }
	}
}

