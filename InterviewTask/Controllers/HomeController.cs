using InterviewTask.Models;
using InterviewTask.Services;
using InterviewTask.Utilities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace InterviewTask.Controllers
{
	public class HomeController : Controller
	{
		readonly HelperServiceRepository helperServiceRepository;
		public HomeController()
		{
			FileLogger.Log("HelperService Request Initialized - " + System.Environment.UserName, "Info");
			helperServiceRepository = new HelperServiceRepository();
		}
		/*
         * Prepare your opening times here using the provided HelperServiceRepository class.       
         */		
		public ActionResult Index()
		{			
			try
			{				
				FileLogger.Log("Loading Marie Curie Service","Info");				
				IEnumerable<HelperServiceModel> serviceModelList = helperServiceRepository.Get();
				foreach (var item in serviceModelList)
				{					
					helperServiceRepository.GetOpeningClosedStatus(item);
				}
				return View(serviceModelList);				
			}
			catch (Exception ex)
			{
				FileLogger.Log(ex.Message, "Error");
				return View();
			}
		} 		
	}
}