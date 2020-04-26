using InterviewTask.Models;
using InterviewTask.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Net;

namespace InterviewTask.Services
{
	public class WeatherDetails
	{
		/// <summary>
		/// Gets the Weather based on City
		/// </summary>
		/// <param name="city"></param>
		/// <returns></returns>
		public WeatherModel GetWeather(string city)
		{
			FileLogger.Log("Weather Request Initialized for City: " + city, "Info");
			string appId = ConfigurationManager.AppSettings["ApiId"];
			string url = string.Format(ConfigurationManager.AppSettings["WeatherApi"], city, appId);
			using (WebClient client = new WebClient())
			{

				WeatherModel weatherModel = new WeatherModel(city);
				try
				{					
					string resultJson = client.DownloadString(url);
					JObject resultJObject = JObject.Parse(resultJson);
					weatherModel=GetWeatherDetails(resultJObject, city);
					return weatherModel;
				}
				catch (Exception ex)
				{
					FileLogger.Log(ex.Message, "Error");
					weatherModel.ErrorMsg = Constants.WEATHER_ERROR_MESSAGE;
					return weatherModel;
				}
			}
		}
		/// <summary>
		/// Returns the weather details 
		/// </summary>
		/// <param name="resultJObject"></param>
		/// <param name="city"></param>
		/// <returns></returns>
		public WeatherModel GetWeatherDetails(JObject resultJObject, string city)
		{
			WeatherModel weatherModel = new WeatherModel(city);		
			weatherModel.Humidity = resultJObject["main"]["humidity"].ToString();
			weatherModel.TempMax = resultJObject["main"]["temp_max"].ToString();
			weatherModel.TempMin = resultJObject["main"]["temp_min"].ToString();
			weatherModel.Temp = resultJObject["main"]["temp"].ToString();
			weatherModel.Lat = resultJObject["coord"]["lat"].ToString();
			weatherModel.Lon = resultJObject["coord"]["lon"].ToString();
			weatherModel.Country = resultJObject["sys"]["country"].ToString();
			weatherModel.City = resultJObject["name"].ToString();
			weatherModel.Description = resultJObject["weather"][0]["description"].ToString();
			weatherModel.Appid = resultJObject["wind"]["speed"].ToString();
			return weatherModel;
		}
	}
}