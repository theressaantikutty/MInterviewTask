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
			Assert.AreEqual(input.ServiceCenterStatus.IsOpen, false);
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
			Assert.AreEqual(input.ServiceCenterStatus.OpenClosedStatus, "We're sorry, we are temporarily unable to display");
		}
		[TestMethod]
		public void Test_GetOpeningClosedStatus_WhenClosedMessageSundayOpenCheck()
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
				MondayOpeningHours = new List<int> { 0, 0 },
				TuesdayOpeningHours = new List<int> { 0, 0 },
				WednesdayOpeningHours = new List<int> { 0, 0 },
				ThursdayOpeningHours = new List<int> { 0, 0 },
				FridayOpeningHours = new List<int> { 0, 0 },
				SaturdayOpeningHours = new List<int> { 0, 0 },
				SundayOpeningHours = new List<int> { 9, 12 },
				TelephoneNumber = "0207 0000000",
				Location = "London"
			};
			//Act
			helperServiceFactory.GetOpeningClosedStatus(input);

			//Assert
			Assert.AreEqual(input.ServiceCenterStatus.IsOpen, true);
		}

		[TestMethod]
		public void Test_GetOpeningClosedStatus_WhenOpenMessageSundayOpenCheck()
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
				SundayOpeningHours = new List<int> { 9, 12 },
				TelephoneNumber = "0207 0000000",
				Location = "London"
			};
			//Act
			helperServiceFactory.GetOpeningClosedStatus(input);

			//Assert
			Assert.AreEqual(input.ServiceCenterStatus.OpenClosedStatus, "Open today until 12 PM");
		}
	}
}
