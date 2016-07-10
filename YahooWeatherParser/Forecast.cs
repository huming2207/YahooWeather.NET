﻿using System;
using Newtonsoft.Json;

namespace YahooWeatherParser
{
	[JsonObject]
	public class Forecast
	{
		[JsonProperty(PropertyName = "code")]
		public ConditionCode Code { get; set; }

		[JsonProperty(PropertyName = "date")]
		public string Date { get; set; }

		[JsonProperty(PropertyName = "day")]
		public string Day { get; set;}

		[JsonProperty(PropertyName = "high")]
		public int High { get; set; }

		[JsonProperty(PropertyName = "low")]
		public int Low { get; set; }

		[JsonProperty(PropertyName = "text")]
		public string Text { get; set; }

	}
}

