using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTask.Models
{
	public class WeatherModel
	{
		public WeatherModel(string _city)
		{
			this.City = _city;
		}
		public string Country { get; set; }
		public string City { get; set; }
		public string Lat { get; set; }
		public string Lon { get; set; }
		public string Description { get; set; }
		public string Humidity { get; set; }
		public string Temp { get; set; }
		public string TempMax { get; set; }
		public string TempMin { get; set; }
		public string Appid { get; set; }
		public string ErrorMsg { get; set; }
	}
}