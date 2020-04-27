using InterviewTask.Filters;
using InterviewTask.Models;
using InterviewTask.Services;
using InterviewTask.Utilities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace InterviewTask.Controllers
{
	[HelperServiceFilter]
	public class HomeController : Controller
	{
		readonly HelperServiceRepository helperServiceRepository;
		public HomeController()
		{
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
				throw ex;				
			}
		} 		
	}
}