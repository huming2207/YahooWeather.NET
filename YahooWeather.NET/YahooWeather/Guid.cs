using System;
using Newtonsoft.Json;

namespace YahooWeather.NET
{
	[JsonObject()]
	public class Guid
	{
		[JsonProperty(PropertyName = "isPermaLink")]
		public bool IsPermanentLink { get; set; }
	}
}

