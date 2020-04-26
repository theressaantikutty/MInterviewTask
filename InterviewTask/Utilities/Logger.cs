using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace InterviewTask.Utilities
{
	public class FileLogger 
	{		
	    static readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["LogFile"];	
		public static void Log(string logMessage,string messageType)
		{
			using (StreamWriter streamWriter = File.AppendText(filePath))
			{				
				streamWriter.WriteLine("{0} - {1} - {2}", DateTime.Now, messageType, logMessage);									
				streamWriter.Close();
			}
		}	
	}
}