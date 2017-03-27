using System;
using Newtonsoft.Json;

namespace YahooWeatherParser.Shared
{
	[JsonObject()]
	public class Guid
	{
		[JsonProperty(PropertyName = "isPermaLink")]
		public bool IsPermanentLink { get; set; }
	}
}

