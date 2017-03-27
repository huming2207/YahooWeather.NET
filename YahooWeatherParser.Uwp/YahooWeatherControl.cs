/*
 *  Yahoo Weather .NET Parsing Library
 *  Written By "Jackson" Ming Hu, 2017
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using YahooWeatherParser.Shared;
using Newtonsoft.Json;

namespace YahooWeatherParser.Uwp
{
	public class YahooWeatherControl
	{
		private const string ApiBaseUrl = "https://query.yahooapis.com";
		private const string YqlBaseStr = "/v1/public/yql?q=";
		private const string YqlQuery = "select * from weather.forecast where woeid in (select woeid from geo.places(1) where text=\"{0}, {1}\")";
		private const string YqlCelsiusTemp = " and u=\'c\'";
		private const string MiscStr = "&format=json&diagnostics=false&env=store://datatables.org/alltableswithkeys&callback=";

		public YahooWeatherControl(bool useCelsius = true)
		{
			UseCelsiusUnit = useCelsius;
		}

		public bool UseCelsiusUnit { get; private set;}

		private HttpClient GetHttpClient()
		{
			var client = new HttpClient();
			client.BaseAddress = new Uri(YahooWeatherControl.ApiBaseUrl);
			Debug.WriteLine("REQUEST HTTP ADDR: " + ApiBaseUrl);
			return client;
		}

		private async Task<T> ExecuteAsync<T>(string yqlQuery)
		{
			string CallUrl = string.Empty;
			if (UseCelsiusUnit)
			{
				CallUrl = ApiBaseUrl + YqlBaseStr + Uri.EscapeDataString(yqlQuery) + Uri.EscapeDataString(YqlCelsiusTemp) + MiscStr;
			}
			else 
			{
				CallUrl = ApiBaseUrl + YqlBaseStr + Uri.EscapeDataString(yqlQuery) + MiscStr;
			}

			Debug.WriteLine("REQUEST HTTP ADDR: " + CallUrl);

			using (var client = GetHttpClient())
			{
				var json = await client.GetStringAsync(CallUrl);
				var result = JsonConvert.DeserializeObject<T>(json, new QueryConverter());
				return result;
			}
		}

		public async Task<Query> DoQuery(string city, string region)
		{
			var yqlQuery = string.Format(YqlQuery, city, region);
			var result = await this.ExecuteAsync<Query>(yqlQuery);
			return result;
		}

	}
}



