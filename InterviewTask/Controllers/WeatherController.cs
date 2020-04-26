using InterviewTask.Models;
using InterviewTask.Services;
using System.Web.Mvc;
namespace InterviewTask.Controllers
{
	public class WeatherController : Controller 
	{
		// GET: Weather
		public ActionResult Weather()
		{
			return View();
		}
		/// <summary>
		/// Getting weather Information
		/// </summary>
		/// <param name="city"></param>
		/// <returns></returns>
		public ActionResult GetWeather(string city)
		{
			WeatherDetails weatherDetails = new WeatherDetails();			
			WeatherModel weatherModel = weatherDetails.GetWeather(city);
			return PartialView("Weather", weatherModel);
		}
	}
}
	