﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YahooWeather.NET
{
	public class QueryConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			if (objectType == typeof(Query))
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
			var queryWrapper = JObject.Load(reader);

			if (queryWrapper.Property("query") != null)
			{
				var queryInfo = queryWrapper["query"];
				Query queryResult = queryInfo.ToObject<Query>();
				return queryResult;
			}
			else
			{
				throw new ArgumentNullException();
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}

