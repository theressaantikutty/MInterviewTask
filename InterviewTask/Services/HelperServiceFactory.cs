﻿using System;
using System.Collections.Generic;
using InterviewTask.Models;
using InterviewTask.Utilities;

namespace InterviewTask.Services
{
    public class HelperServiceFactory
    {		
		int dayCount;
		internal static List<HelperServiceModel> Create()
        {
			var weekdayOpeningTimes = new List<int> { 9, 17 };
			var alternativeOpeningTime = new List<int> { 8, 12 };
			var weekendOpeningTimes = new List<int> { 10, 12 };
			var closedTimes = new List<int> { 0, 0 };

			var description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " 
				//+
				//"Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
				;
		
			var eastLondonHelper = new HelperServiceModel
			{
				Title = "East London Helper Service",
				Description = description,
				Id = Guid.Parse("FD15B5C7-EF00-4623-8CEA-20E7513283FC"),
				MondayOpeningHours = closedTimes,
				TuesdayOpeningHours = weekdayOpeningTimes,
				WednesdayOpeningHours = alternativeOpeningTime,
				ThursdayOpeningHours = weekdayOpeningTimes,
				FridayOpeningHours = weekdayOpeningTimes,
				SaturdayOpeningHours = closedTimes,
				SundayOpeningHours = closedTimes,
				TelephoneNumber = "0207 0000000",
				Location= "London"
			};

            var northLondonHelper = new HelperServiceModel
            {
                Title = "North London Helper Service",
                Description = description,
                Id = Guid.Parse("BB1FDCB3-AA8B-4A86-8DFD-74F0C475118F"),
                MondayOpeningHours = weekdayOpeningTimes,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = weekdayOpeningTimes,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = closedTimes,
                SaturdayOpeningHours = closedTimes,
                SundayOpeningHours = closedTimes,
                TelephoneNumber = "0207 0000000",
				Location= "London"
            };

            var bristolHelper = new HelperServiceModel
            {
                Title = "Bristol Helper Service",
                Description = description,
                Id = Guid.Parse("DC7F8E65-E8DB-4294-973B-569DA4EC280C"),
                MondayOpeningHours = closedTimes,
                TuesdayOpeningHours = closedTimes,
                WednesdayOpeningHours = weekdayOpeningTimes,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = closedTimes,
                SundayOpeningHours = closedTimes,
                TelephoneNumber = "0117 0000000",
				Location = "Bristol"
			};

            var somersetHelper = new HelperServiceModel
            {
                Title = "Somerset Helper Service",
                Description = description,
                Id = Guid.Parse("B133869D-EB46-4F6B-B1D1-6B57581AAC92"),
                MondayOpeningHours = alternativeOpeningTime,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = closedTimes,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = closedTimes,
                SundayOpeningHours = closedTimes,
                TelephoneNumber = "0207 0000000",
				Location = "Somerset"

			};

            var nottinghamHelper = new HelperServiceModel
            {
                Title = "Nottingham Helper Service",
                Description = description,
                Id = Guid.Parse("284BCC28-6E47-4EB2-B7BB-B9A1BB1CD4B4"),
                MondayOpeningHours = alternativeOpeningTime,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = weekdayOpeningTimes,
                ThursdayOpeningHours = closedTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = weekdayOpeningTimes,
                SundayOpeningHours = weekdayOpeningTimes,
                TelephoneNumber = "0116 0000000",
				Location = "Nottingham"
			};

            var liverpoolHelper = new HelperServiceModel
            {
                Title = "Liverpool Helper Service",
                Description = description,
                Id = Guid.Parse("FD15B5C7-EF00-4624-8CEA-20E7513283FC"),//Changed the Id to be unique
				MondayOpeningHours = weekdayOpeningTimes,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = alternativeOpeningTime,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = weekendOpeningTimes,
                SundayOpeningHours = weekendOpeningTimes,
                TelephoneNumber = "0151 0000000",
				Location = "Liverpool"
			};

            var northernIrelandHelper = new HelperServiceModel
            {
                Title = "Belfast Helper Service",
                Description = description,
                Id = Guid.Parse("3FCE3EFD-9713-4449-8DFF-A6FF3D771993"),
                MondayOpeningHours = weekdayOpeningTimes,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = weekdayOpeningTimes,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = weekdayOpeningTimes,
                SundayOpeningHours = weekendOpeningTimes,
                TelephoneNumber = "0289 0000000",
				Location = "Belfast"
			};

            var westMidlandsHelper = new HelperServiceModel
            {
                Title = "West Midlands Helper Service",
                Description = description,
                Id = Guid.Parse("7BA5E5E1-C29E-40BA-832B-F145DEE37A5D"),
                MondayOpeningHours = alternativeOpeningTime,
                TuesdayOpeningHours = alternativeOpeningTime,
                WednesdayOpeningHours = alternativeOpeningTime,
                ThursdayOpeningHours = alternativeOpeningTime,
                FridayOpeningHours = alternativeOpeningTime,
                SaturdayOpeningHours = alternativeOpeningTime,
                SundayOpeningHours = alternativeOpeningTime,
                TelephoneNumber = "0289 0000000",
				Location = "West Midlands"
			};

            var walesHelper = new HelperServiceModel
            {
                Title = "Wales Helper Service",
                Description = description,
                Id = Guid.Parse("C9EB3091-CDF0-4F7E-9435-3ACEF695EDFE"),
                MondayOpeningHours = weekdayOpeningTimes,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = weekdayOpeningTimes,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = weekdayOpeningTimes,
                SundayOpeningHours = weekendOpeningTimes,
                TelephoneNumber = "029 8800000",
				Location = "Wales"
			};

            var fifeHelper = new HelperServiceModel
            {
                Title = "Fife Helper Service",
                Description = description,
                Id = Guid.Parse("078767E1-5695-42DD-AD9A-4310535C93F0"),
                MondayOpeningHours = weekdayOpeningTimes,
                TuesdayOpeningHours = weekdayOpeningTimes,
                WednesdayOpeningHours = weekdayOpeningTimes,
                ThursdayOpeningHours = weekdayOpeningTimes,
                FridayOpeningHours = weekdayOpeningTimes,
                SaturdayOpeningHours = weekdayOpeningTimes,
                SundayOpeningHours = weekendOpeningTimes,
                TelephoneNumber = "0159 2000000",
				Location = "Fife"
			};

            var openingHours = new List<HelperServiceModel> { eastLondonHelper, northLondonHelper, bristolHelper, somersetHelper, nottinghamHelper, liverpoolHelper, northernIrelandHelper, westMidlandsHelper, walesHelper, fifeHelper };

            return DeliberateBug(openingHours);
        }        
        private static List<HelperServiceModel> DeliberateBug(List<HelperServiceModel> openingHours)
        {
            var listCount = openingHours.Count;

            var rnd = new Random();

            var elementToDayNull = rnd.Next(0, listCount - 1);

            //Simulate a lack of response from the server: 10% of the time, set weekday opening hours to null
            // Handle this bug in your view - a simple error message (We're sorry, we are temporarily unable to display etc etc ) in the view cards is fine
            if (rnd.Next(1, 10) > 9)
            {
                openingHours[elementToDayNull].MondayOpeningHours = null;
                openingHours[elementToDayNull].TuesdayOpeningHours = null;
                openingHours[elementToDayNull].WednesdayOpeningHours = null;
                openingHours[elementToDayNull].ThursdayOpeningHours = null;
                openingHours[elementToDayNull].FridayOpeningHours = null;
            }

            return openingHours;
        }
		/// <summary>
		/// Get the OpeningTimes and Open or Closed status of service center
		/// </summary>
		/// <param name="helperService"></param>
		public void GetOpeningClosedStatus(HelperServiceModel helperService)
		{
			FileLogger.Log("GetOpeningClosedStatus Initialized ", Constants.INFO);
			try
			{
				helperService.ServiceCenterStatus = new ServiceCenterStatus
				{
					IsOpen = true
				};
				dayCount = 0;
				SetOpenigHours(helperService, DateTime.Today, false);
			}
			catch (Exception ex)
			{
				FileLogger.Log(ex.Message, "Error");
				throw ex;
			}		
		}
		/// <summary>
		/// Sets the OpeningTimes and Open or Closed status of service center based on the Current day
		/// </summary>
		/// <param name="helperService"></param>
		/// <param name="day"></param>
		/// <param name="nextDaystatus"></param>
		private void SetOpenigHours(HelperServiceModel helperService, DateTime day, bool nextDaystatus)
		{			
			List<int> openHours = new List<int>();
			switch (day.DayOfWeek.ToString())
			{
				case "Monday":
					openHours = helperService.MondayOpeningHours;							
					break;
				case "Tuesday":
					openHours = helperService.TuesdayOpeningHours;								
					break;
				case "Wednesday":
					openHours = helperService.WednesdayOpeningHours;
					break;
				case "Thursday":
					openHours = helperService.ThursdayOpeningHours;
					break;
				case "Friday":
					openHours = helperService.FridayOpeningHours;
					break;
				case "Saturday":
					openHours = helperService.SaturdayOpeningHours;
					break;
				case "Sunday":
					openHours = helperService.SundayOpeningHours;
					break;
			}
			if (openHours == null)//Handles Deliberate bug
			{
				helperService.ServiceCenterStatus.OpenClosedStatus = Constants.TIMING_MESSAGE;
			}
			else
			{
				if ((openHours[0] > 0))//Checks if open on that day
				{
					if (!nextDaystatus)//Checks if current day
					{
						if ((DateTime.Now.Hour >= openHours[0]) && (DateTime.Now.Hour < openHours[1]))//Checks if open at current time and current day
						{
							helperService.ServiceCenterStatus.OpenClosedStatus = Constants.OPEN_STATUS + ConvertTime(openHours[1].ToString());
						}
						else if((DateTime.Now.Hour < openHours[0]))
						{
							helperService.ServiceCenterStatus.OpenClosedStatus = Constants.CLOSED_STATUS + day.DayOfWeek.ToString() + " at " + ConvertTime(openHours[0].ToString());
							helperService.ServiceCenterStatus.IsOpen = false;
						}
						else
						{
							dayCount++;
							SetClosedStatus(helperService, day);
						}
					}
					else // setting Reopen day and time
					{
						helperService.ServiceCenterStatus.OpenClosedStatus = Constants.CLOSED_STATUS + day.DayOfWeek.ToString() + " at " + ConvertTime(openHours[0].ToString());
					}
				}
				else 
				{
					dayCount++;
					SetClosedStatus(helperService, day);
				}
			}
			
		}
		/// <summary>
		/// Convert time to 12-hour format
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		private string ConvertTime(String time)
		{
			string convertedTime;
			if (Convert.ToInt32(time) > 12)
			{
				convertedTime = (Convert.ToInt32(time) - 12).ToString() + " PM";
			}
			else if(Convert.ToInt32(time) < 12)
			{
				convertedTime = time + " AM";
			}
			else
			{
				convertedTime = time + " PM";
			}
			return convertedTime;
		}
		/// <summary>
		/// Shows message if service center has no openclosed timings
		/// Sets the next workind day based on openclosed timings
		/// </summary>
		/// <param name="helperService"></param>
		/// <param name="day"></param>
		private void SetClosedStatus(HelperServiceModel helperService, DateTime day)
		{
			helperService.ServiceCenterStatus.IsOpen = false;
			DateTime nextOpenDay = (day).AddDays(1);
			if(dayCount <= 7)
			{
				SetOpenigHours(helperService, nextOpenDay, true);
			}
			else
			{
				helperService.ServiceCenterStatus.IsOpen = false;
				helperService.ServiceCenterStatus.OpenClosedStatus = Constants.TIMING_MESSAGE;
			}
			
		}
	}
}