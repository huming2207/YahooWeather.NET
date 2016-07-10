using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YahooWeatherParser
{
	public class ForecastConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			if (objectType == typeof(Forecast[]))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}

