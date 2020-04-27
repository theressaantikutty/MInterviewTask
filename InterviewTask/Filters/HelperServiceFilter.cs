using InterviewTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewTask.Filters
{
	public class HelperServiceFilter : ActionFilterAttribute,IExceptionFilter
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var message = "Action: "+filterContext.ActionDescriptor.ActionName +"||Contoller: "+filterContext.ActionDescriptor.ControllerDescriptor.ControllerName+
				"||Contoller: " +System.Environment.UserName;
			FileLogger.Log(message, "Info");
		}
		public void OnException(ExceptionContext filterContext)
		{
			FileLogger.Log(filterContext.Exception.Message, "Error");
		}
		
	}
}