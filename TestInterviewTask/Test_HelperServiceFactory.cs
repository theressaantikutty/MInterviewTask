using System;
using System.Collections.Generic;
using InterviewTask.Models;
using InterviewTask.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewTask_Tests
{
	[TestClass]
	public class Test_HelperServiceFactory
	{
		[TestMethod]
		public void Test_GetOpeningClosedStatus_WhenClosedStatusCheck()
		{
			//Arrange
			HelperServiceFactory helperServiceFactory = new HelperServiceFactory();
			var input = new HelperServiceModel
			{
				Title = "East London Helper Service",
				Description = "Test data",
				Id = Guid.Parse("FD15B5C7-EF00-4623-8CEA-20E7513283FC"),
				MondayOpeningHours = new List<int> { 0, 0 },
				TuesdayOpeningHours = new List<int> { 0, 0 },
				WednesdayOpeningHours = new List<int> { 0, 0 },
				ThursdayOpeningHours = new List<int> { 0, 0 },
				FridayOpeningHours = new List<int> { 0, 0 },
				SaturdayOpeningHours = new List<int> { 0, 0 },
				SundayOpeningHours = new List<int> { 0, 0 },
				TelephoneNumber = "0207 0000000",
				Location = "London"
			};
			//Act
			helperServiceFactory.GetOpeningClosedStatus(input);

			//Assert
			Assert.AreEqual(false, input.ServiceCenterStatus.IsOpen);
		}

		[TestMethod]
		public void Test_GetOpeningClosedStatus_WhenClosedMessageCheck()
		{
			//Arrange
			HelperServiceFactory helperServiceFactory = new HelperServiceFactory();
			var input = new HelperServiceModel
			{
				Title = "East London Helper Service",
				Description = "Test data",
				Id = Guid.Parse("FD15B5C7-EF00-4623-8CEA-20E7513283FC"),
				MondayOpeningHours = new List<int> { 0, 0 },
				TuesdayOpeningHours = new List<int> { 0, 0 },
				WednesdayOpeningHours = new List<int> { 0, 0 },
				ThursdayOpeningHours = new List<int> { 0, 0 },
				FridayOpeningHours = new List<int> { 0, 0 },
				SaturdayOpeningHours = new List<int> { 0, 0 },
				SundayOpeningHours = new List<int> { 0, 0 },
				TelephoneNumber = "0207 0000000",
				Location = "London"
			};
			//Act
			helperServiceFactory.GetOpeningClosedStatus(input);

			//Assert
			Assert.AreEqual( "We're sorry, we are temporarily unable to display", input.ServiceCenterStatus.OpenClosedStatus);
		}
		[TestMethod]
		public void Test_GetOpeningClosedStatus_WhenClosedMessageOpenCheck()
		{
			//Arrange
			HelperServiceFactory helperServiceFactory = new HelperServiceFactory();
			var input = new HelperServiceModel
			{
				Title = "East London Helper Service",
				Description = "Test data",
				Id = Guid.Parse("FD15B5C7-EF00-4623-8CEA-20E7513283FC"),
				MondayOpeningHours = new List<int> { 0, 0 },
				TuesdayOpeningHours = new List<int> { 0, 0 },
				WednesdayOpeningHours = new List<int> { 0, 0 },
				ThursdayOpeningHours = new List<int> { 0, 0 },
				FridayOpeningHours = new List<int> { 0, 0 },
				SaturdayOpeningHours = new List<int> { 9, 12 },
				SundayOpeningHours = new List<int> { 0, 0 },
				TelephoneNumber = "0207 0000000",
				Location = "London"
			};
			//Act
			helperServiceFactory.GetOpeningClosedStatus(input);

			//Assert
			if ((DateTime.Now.DayOfWeek.ToString() == "Saturday")&&((DateTime.Now.Hour >= 9) && (DateTime.Now.Hour <= 12)))
				Assert.AreEqual("Open Today until 12 PM", input.ServiceCenterStatus.OpenClosedStatus);
			else
				Assert.AreEqual("Reopens Saturday at 9 AM", input.ServiceCenterStatus.OpenClosedStatus);
		}

		[TestMethod]
		public void Test_GetOpeningClosedStatus_WhenOpenStatusCheck()
		{
			//Arrange
			HelperServiceFactory helperServiceFactory = new HelperServiceFactory();
			var input = new HelperServiceModel
			{
				Title = "East London Helper Service",
				Description = "Test data",
				Id = Guid.Parse("FD15B5C7-EF00-4623-8CEA-20E7513283FC"),
				MondayOpeningHours = new List<int> { 9, 12 },
				TuesdayOpeningHours = new List<int> { 9, 12 },
				WednesdayOpeningHours = new List<int> { 9, 12 },
				ThursdayOpeningHours = new List<int> { 9, 12 },
				FridayOpeningHours = new List<int> { 9, 12 },
				SaturdayOpeningHours = new List<int> { 9, 12 },
				SundayOpeningHours = new List<int> { 9, 12 },
				TelephoneNumber = "0207 0000000",
				Location = "London"
			};
			//Act
			helperServiceFactory.GetOpeningClosedStatus(input);

			//Assert
			if ((DateTime.Now.Hour >= 9) && (DateTime.Now.Hour <= 12))
				Assert.AreEqual(input.ServiceCenterStatus.IsOpen, true);
			else
				Assert.AreEqual(input.ServiceCenterStatus.IsOpen, false);
		}
		
	}
}
